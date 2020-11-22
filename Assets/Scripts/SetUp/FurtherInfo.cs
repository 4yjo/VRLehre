using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurtherInfo : MonoBehaviour
{
    //Script to Display Tipps and Instructions to Player if they press Button on Controller

    public GameObject TextToShow;

    private void Start()
    {

        //Search for Text to be shown if it hasn't been assigned by dragging it in the editor slot of this script
        if (TextToShow == null)
        {
            TextToShow = GameObject.Find("furtherInfo");
        }
    }


    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One) || OVRInput.Get(OVRInput.Button.Two) || OVRInput.Get(OVRInput.Button.Start))  // called when Buttons on left controller are pressed
        {
            TextToShow.SetActive(true);
            Debug.Log("LOGTHAT Further Info Text is shown");
        }

        else
        {
            TextToShow.SetActive(false);

        }

    }
}
