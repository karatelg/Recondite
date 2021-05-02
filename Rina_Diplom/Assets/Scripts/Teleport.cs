using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

public GameObject[] tpPoints;
private int keyNum;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.gameObject.transform.position = tpPoints[0].gameObject.transform.position; 
        }    

                if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.gameObject.transform.position = tpPoints[1].gameObject.transform.position; 
        }   

                if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.gameObject.transform.position = tpPoints[2].gameObject.transform.position; 
        }   

                if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            this.gameObject.transform.position = tpPoints[3].gameObject.transform.position; 
        }   

                if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            this.gameObject.transform.position = tpPoints[4].gameObject.transform.position; 
        }   

                if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            this.gameObject.transform.position = tpPoints[5].gameObject.transform.position; 
        }   

                if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            this.gameObject.transform.position = tpPoints[6].gameObject.transform.position; 
        }   

                if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            this.gameObject.transform.position = tpPoints[7].gameObject.transform.position; 
        }   

                if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            this.gameObject.transform.position = tpPoints[8].gameObject.transform.position; 
        }   

                if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            this.gameObject.transform.position = tpPoints[9].gameObject.transform.position; 
        }   

 
    }
}
