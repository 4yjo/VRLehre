using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3Manager : MonoBehaviour
{   public Material lampOn;
    public Material lampOff;
    public GameObject Lamp;
    public GameObject Trigger;
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
        if (checksum == 5){//set to number of slots that need to be correct
            Lamp.GetComponent<Renderer>().material = lampOn;
            Trigger.SetActive(true);
            //NextButton.SetActive(true);
        } 

        else {
            Lamp.GetComponent<Renderer>().material = lampOff;
        }
    }

    

   
}
