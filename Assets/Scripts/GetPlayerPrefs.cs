using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("Dataset")) {
            string inputdata = PlayerPrefs.GetString("Dataset");
            Debug.Log("inputdata"+inputdata);
        }
    }
}
