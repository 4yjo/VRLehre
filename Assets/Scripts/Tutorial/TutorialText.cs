using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialText : MonoBehaviour
{
    [SerializeField] GameObject Display;
    public GameObject Slide1;
    public GameObject Slide2;
    public GameObject Slide3;
    public GameObject Slide4;

    
    // Start is called before the first frame update
    void Start()
    {
       
       Display = Slide1;
       new WaitForSeconds(1f);
       Slide1.SetActive(false);
       Display = Slide2;
       if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp)) {
           Slide2.SetActive(false);
           Display = Slide3;
       }
       
       }

    
}
