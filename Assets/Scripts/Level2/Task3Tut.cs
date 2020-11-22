using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3Tut : MonoBehaviour
{   public Material lampOn;
    public Material lampOff;
    public GameObject Lamp;
    public GameObject Trigger;
    public GameObject IntroductionText;
    public GameObject furtherInstructions;
   // public GameObject NextButton;
    //public int AmountOfSlots;
    private int checksum;

    void Start(){
        checksum = 0;
    }

    public void ChecksumPlus(){
        checksum += 1;
    }

    public void ChecksumMinus(){
        checksum -= 1;
    }
    void Update(){
        if (checksum == 1){//set to number of slots that need to be correct
            Lamp.GetComponent<Renderer>().material = lampOn;
            Trigger.SetActive(true);
            IntroductionText.SetActive(false);
            furtherInstructions.SetActive(true);
           // Lamp.GetComponent<Texty>().SetActive(true);
           // NextButton.SetActive(true);
        } 

        else {
            Lamp.GetComponent<Renderer>().material = lampOff;
        }
    }

    

   
}
