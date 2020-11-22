
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    public int index;


    //public GameObject SolutionImage2;
    public GameObject Lamp;
    public GameObject Trigger;
    public Material lampOn;
    public Material defaultMaterial;
    public GameObject SolutionImage;

    void Update ()
    {
       
        if (index == 6)
        {
            SolutionImage.SetActive(true);
        }

    }
}
