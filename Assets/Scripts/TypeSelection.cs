using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TypeSelection : MonoBehaviour
{
    [SerializeField] private string loadLevel;
    public void BarChartSel()
    {
        SceneManager.LoadScene(loadLevel); //name of next scene set in editor
    }
}
