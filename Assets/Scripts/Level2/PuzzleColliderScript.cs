using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleColliderScript : MonoBehaviour
{
    public string SlotNumber;
    public Material lampOn;
    public Material lampOff;
    public GameObject Lamp;

    void OnStart(){
        Debug.Log("testlog");
        Debug.Log(SlotNumber);
        
    }
    public void OnTriggerEnter(Collider other)
    {  
       if (other.CompareTag("Tile1"))
       {
           Lamp.GetComponent<Renderer>().material = lampOn;
           Debug.Log("todo set true");
          // GameObject g = GameObject.Find("Task3Manager");
           //g.GetComponent<Task3Manager>().ChecksumPlus();
       }
    }

    // public void OnTriggerExit(Collider other)
    // {  
    //    if (other.CompareTag("Tube"))
    //    {
    //         GameObject g = GameObject.Find("Task3Manager");
    //        g.GetComponent<Task3Manager>().ChecksumMinus();
    //    }
    // }
}
