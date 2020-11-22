using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPuzzleSlot : MonoBehaviour
{
   public string Tag;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            GameObject puzzle = GameObject.Find("PuzzleManager");
            puzzle.GetComponent<PuzzleManager>().index +=1;
            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            GameObject puzzle = GameObject.Find("PuzzleManager");
            puzzle.GetComponent<PuzzleManager>().index -= 1;
        }
    }
}