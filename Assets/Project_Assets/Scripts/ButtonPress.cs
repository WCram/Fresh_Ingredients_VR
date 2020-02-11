using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public Material Inactive;
    public Material Active;
    Renderer ObjRend;

    // Start is called before the first frame update
    void Start()
    {
        ObjRend = this.GetComponent<Renderer>();
        ObjRend.material = Inactive;


    } // End Start()

    // Update is called once per frame
    //void Update()
    //{

    //} // End Update()

} // End class ButtonPress
