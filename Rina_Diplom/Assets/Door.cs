using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int DoorIndex = -1;
    
    public GameObject[] triggers;
    
    public Animation anim;
    
    public void Open()
    {
        foreach (GameObject trigger in triggers)
        {
            trigger.SetActive(true);
        }
        
        anim.Play();
        Journal.AddOpenedDoorIndex(DoorIndex);
    }
}
