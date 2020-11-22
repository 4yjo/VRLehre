using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerDisplay : MonoBehaviour
{
    //public Collider CDCollider;
    public GameObject DisplayOnOff;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Tile1")
        {
            DisplayOnOff.SetActive(false);
        }
    }


}
