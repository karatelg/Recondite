using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    public float Vertical;
    public GameObject MainCamera;
    public float Horizontal;
    public FirstPersonAIO walk;
    public float Sensivity = 10F;
 
    private Vector3 MousePos;
    private float MyAngleX;
    private float MyAngleY;
    Quaternion originalRotation;
    Quaternion QuaternionX;
    Quaternion QuaternionY;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        walk = gameObject.GetComponent<FirstPersonAIO>();
        originalRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.gravity.y == 0)
        {


            MyAngleX += Sensivity * Input.GetAxis("Mouse X");
            MyAngleY += Sensivity * Input.GetAxis("Mouse Y");
            QuaternionX = Quaternion.AngleAxis(MyAngleX, Vector3.up);
             QuaternionY = Quaternion.AngleAxis(MyAngleY, -Vector3.right);
            transform.localRotation = originalRotation* QuaternionX * QuaternionY;

            walk.GetComponent<FirstPersonAIO>().enabled = false;
          
            Vertical = Input.GetAxis("Vertical");
            Horizontal = Input.GetAxis("Horizontal");
            rb.AddForce(Vertical * 200f * MainCamera.transform.forward * Time.deltaTime);
            rb.AddForce(Horizontal * 200f * MainCamera.transform.right * Time.deltaTime);





        }
        else { walk.GetComponent<FirstPersonAIO>().enabled = true; }

    }
}
