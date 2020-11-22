
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutPuzzleManager : MonoBehaviour
{
    public bool slot1right = false;
    public bool slot2right = false;
    public bool slot3right = false;
    public bool slot4right = false;
    public bool slot5right = false;
    public bool slot6right = false;

    public GameObject Lamp;
    public GameObject Trigger;
    public Material lampOn;


    void Update (){
        if (slot1right) {
            Lamp.GetComponent<Renderer>().material = lampOn;
            Trigger.SetActive(true);
        }
    }

}
