using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCanvasContext : MonoBehaviour
{
    public GameObject previousCanvas;
    public GameObject nextCanvas;
    public void ShowCanvas()
    {
        Debug.Log("UUUUUUUUH YEAH");
        if (nextCanvas != null)
        {
            previousCanvas.SetActive(false);
            nextCanvas.SetActive(true);
        }
           

    }
}