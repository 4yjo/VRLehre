using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
 public GameObject WrongDChoice;
 public GameObject Wall;
 public GameObject ButtonCanvas;
 //private Animator animator;


//  void Start(){
//     animator = GetComponent<Animator>();
//  }

 public void OnClickRightChoice(){
    
    ButtonCanvas.SetActive(false);
    Wall.SetActive(false);
 }

 
 public void OnClickWrongChoice(){
    ButtonCanvas.SetActive(false);
    WrongDChoice.SetActive(true);
 }

 public void OnClickAgree(){
    // insert if statement to check if its not active already
    WrongDChoice.SetActive(false);
    ButtonCanvas.SetActive(true);
   
     
 }
}
