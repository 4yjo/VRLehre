using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyToDoor : MonoBehaviour
{
    public GameObject door;
    public GameObject Lamp;
    public Material mat1;

    Collider theCollider;
    
    void OnTriggerEnter(Collider other){
        //nur wenn other == key)
        Lamp.GetComponent<Renderer>().material = mat1;
        theCollider = door.GetComponent<BoxCollider>();
        theCollider.enabled = !theCollider.enabled;
    }
}
