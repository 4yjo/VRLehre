using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeTutColl : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {  
       if (other.CompareTag("Tube"))
       {
           GameObject g = GameObject.Find("Task3Manager");
           g.GetComponent<Task3Tut>().ChecksumPlus();
       }
    }

     public void OnTriggerExit(Collider other)
    {  
       if (other.CompareTag("Tube"))
       {
            GameObject g = GameObject.Find("Task3Manager");
           g.GetComponent<Task3Tut>().ChecksumMinus();
       }
    }
}
