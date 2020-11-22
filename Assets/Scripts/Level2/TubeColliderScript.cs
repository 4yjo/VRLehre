using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeColliderScript : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {  
       if (other.CompareTag("Tube"))
       {
           GameObject g = GameObject.Find("Task3Manager");
           g.GetComponent<Task3Manager>().ChecksumPlus();
       }
    }

     public void OnTriggerExit(Collider other)
    {  
       if (other.CompareTag("Tube"))
       {
            GameObject g = GameObject.Find("Task3Manager");
           g.GetComponent<Task3Manager>().ChecksumMinus();
       }
    }
}
