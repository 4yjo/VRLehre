using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XBarChartPlotter : MonoBehaviour
{
   public GameObject ErrorCanvas;

   public void ShowError(){

    if (ErrorCanvas != null)
        {
            ErrorCanvas.SetActive(true);
        }

   }
}
