using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class CommunictionComponentsGameObjects : MonoBehaviour
{

    //1. Reference via Editor, Variable must be public or [SeriealizeField] > see access modifier c#

    // A)
    //public GameObject myGameObject;
    // B)
    //public Transform myTransform;

    //2. Reference via Script 
    // this is needed if GameObjects are instantiated on Runtime
    // maybe better Workflow anyways 

    //2.A Referencing Component(s) from same GameObject
    // note that RequireComponent above class is recommended
    private Rigidbody myRigidbody;
        

    // Start is called before the first frame update
    void Start()
    {
        //2A)
        myRigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //1A) myGameObject.transform.position = Vector3.up * Time.time;
        //1B) myTransform.position = Vector3.up * Time.time;

        //2A) 
        myRigidbody.AddForce(Vector3.up * 50); //only works if Rigidbody attached to GameObject > force with RequireComponent
    }
}
