using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroText : MonoBehaviour
{
    [SerializeField] GameObject Welcome;
    [SerializeField] GameObject HowToWalk;
    [SerializeField] GameObject ControllerImage;
    [SerializeField] GameObject HowToGrab;
    [SerializeField] GameObject HowToGetStarted;

    [SerializeField] GameObject ControlPanel;
    [SerializeField] GameObject Computer;
    [SerializeField] GameObject ControllButtons;
    [SerializeField] GameObject CD;
    
    private bool walked= false;
    
    void Start(){
        Welcome.SetActive(true);
        HowToWalk.SetActive(false);
        ControllerImage.SetActive(false);
        HowToGrab.SetActive(false);
        HowToGetStarted.SetActive(false);

        new WaitForSeconds(5f);
        Welcome.SetActive(false);
        HowToWalk.SetActive(true);
        ControllerImage.SetActive(true);
    }

    void Update(){
        if (walked == false){
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp)) {
           HowToWalk.SetActive(false);
           ControllerImage.SetActive(false);
           HowToGrab.SetActive(true);
           walked = true;

           new WaitForSeconds(8f);
           ControlPanel.SetActive(true);
           Computer.SetActive(true);
           ControllButtons.SetActive(true);
           CD.SetActive(true);

           new WaitForSeconds(1f);
           HowToGrab.SetActive(false);
           HowToGetStarted.SetActive(true);

        }

        
        
    }
 }

}
