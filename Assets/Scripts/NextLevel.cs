using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// following the tutorial "How to Change Scenes Using a Trigger in Unity 5" by Lurony
// source: https://www.youtube.com/watch?v=tCe_UfyirT4&t=158s, last viewed 14.10.2019

public class NextLevel : MonoBehaviour
{
    [SerializeField] private string loadLevel;
   // [SerializeField] public GameObject agreementDialogue; //displays dialogue when entering collider
   // private bool playerAgreement;

    // public void OnTriggerEnter(Collider other)
    // {  
    //    if (other.CompareTag("Player"))
    //    {
    //        Debug.Log("Trigger Entered");
    //        //set canvas active and show buttons
    //        agreementDialogue.SetActive(true);
    //    }
    // }

    public void OnTriggerEnter(Collider other)
    {  
       
        SceneManager.LoadScene(loadLevel); //loading in editor assigned level as next level
       
    }


    public void OnClickAgree()
   {
       SceneManager.LoadScene(loadLevel); //loading in editor assigned level as next level
   }

//     public void OnClickDisagree()
//    {
//        agreementDialogue.SetActive(false);  //hide dialogue again 
//    }

//     public void OnTriggerExit(Collider other)
//     {
//         agreementDialogue.SetActive(false);  //hide dialogue again 
//     }
 }
