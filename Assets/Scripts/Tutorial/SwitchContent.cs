using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchContent : MonoBehaviour
{
    // This script manages the content shown on computer display
    // if user presses buttons with arrows the next/previous slide is shown

    // the content is stored in an array, so that the buttons can easily get
    // the previous or next content.

    // to use two different action for colliders the "next"button is a capsule collider
    // and the "previous" button is a sphere collider

   [SerializeField] GameObject Display;
   //public Material toChangeto;
   public Material[] myMaterials = new Material[3];
   private int index=0;
   private bool cdinside;

   public GameObject CDCollider;

//    void Start(){
//        //CDCollider.GetComponent<ComputerDisplay>();
//        if (CDCollider.GetComponent<ComputerDisplay>().showContent){
//            cdinside = true;
//            Display.GetComponent<Renderer>().material = myMaterials[index];
//        }
//    }


    // public void OnTriggerEnter(Collider other)
    // { 
    //     //Display.GetComponent<Renderer>().material = toChangeto;  
    //       // if ( index <3){
    //           // index +=1;
    //            Display.GetComponent<Renderer>().material = myMaterials[index];
    //            yield return new WaitForSeconds(1); //so that button is not clicked twice on accident
    //       // }
    //     }   
}