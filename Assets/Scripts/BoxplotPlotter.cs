using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxplotPlotter : MonoBehaviour
{
    public void OnTriggerEntered(Collider other)
    {
    if (other.CompareTag("DataObject"))
    {
        Debug.Log("Object entered Trigger");
    }
    }
}
