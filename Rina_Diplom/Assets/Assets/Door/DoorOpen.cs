using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    public bool stayNear;
    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stayNear == true)
        {
            anim.Play();
        }
    }


    void OnTriggerStay (Collider other)
    {
        if (other.tag == "Player")
        {
            stayNear = true;
        }

    }

        void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            stayNear = false;
        }

    }
}
