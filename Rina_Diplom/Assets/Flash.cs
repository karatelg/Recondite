using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public Light flash;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flash.enabled  == true)
            {
            
            flash.enabled = false;
            Debug.Log("wow");}

            else
{
            flash.enabled = true;
            Debug.Log("wow2");
}

        }
    }
}
