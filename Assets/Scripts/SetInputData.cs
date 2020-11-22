using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetInputData : MonoBehaviour
{
    //connect to Dataset panels in Scene
    //[SerializeField] private GameObject D1Button;


    // Start is called before the first frame update
    // void Start()
    // {
    //     string default_value = "x"; //set default value 
    //     PlayerPrefs.SetString ("Dataset", default_value);
    //     Debug.Log(PlayerPrefs.GetString("Dataset"));
    // }

    // to call if D1 is clicked
    public void SelectD1()
    {
        string data1_value = "iris.csv"; 
        PlayerPrefs.SetString ("Dataset", data1_value);
        Debug.Log(PlayerPrefs.GetString("Dataset"));  

        SceneManager.LoadScene(1); //change index of Level if needed (index from build settings)
    }
}
