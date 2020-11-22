
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot1TutCheck : MonoBehaviour
{
   public void OnTriggerEnter(Collider other)
    {  
       if (other.CompareTag("Tile1"))
       {
           GameObject g = GameObject.Find("Puzzle");
           g.GetComponent<TutPuzzleManager>().slot1right = true;
       }
    }

    public void OnTriggerExit(Collider other)
    {  
           GameObject g = GameObject.Find("Puzzle");
           g.GetComponent<TutPuzzleManager>().slot1right = false;
    }
}
