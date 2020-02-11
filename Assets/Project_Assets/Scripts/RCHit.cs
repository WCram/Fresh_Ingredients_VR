using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RCHit : MonoBehaviour
{

    public float rayLength;
    RaycastHit rch;
    // Start is called before the first frame update
    void Start()
    {
        rayLength = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * rayLength, Color.red, 0.5f);
        if (Physics.Raycast(transform.position, transform.forward, out rch, 2.0F))
        {
            if(rch.transform.tag == "button")
            {
                Debug.Log("Button Touched");
            }
        } 
    }
}
