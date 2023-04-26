using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoor : MonoBehaviour
{

    public Animation hingehere;


    void Start()
    {

    }

    void OnTriggerStay()
    {

        if (Input.GetKey (KeyCode.E))
            hingehere.Play ();
    }
}
