using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// code following the tutorial https://www.youtube.com/watch?v=LziIlLB2Kt4
public class MoreInfo : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        Debug.Log("UUUUUUUUH YEAH");
        if (Panel != null) // check if Panel is assigned
        {
            Panel.SetActive(true);
        }
    }

}
