using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animation anim;

    public string title;

    public int itemId;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        anim.Play();
    }
}
