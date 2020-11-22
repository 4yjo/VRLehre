using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHolderScript : MonoBehaviour
{ 

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tile1"))
        {
            Debug.Log("LOGTHAT: " + other.tag + " PLACED ON BALANCE");
            float weight = 10.0f;
            GetComponentInParent<BalanceScript>().scaleBalance(weight);
        }

        if (other.CompareTag("Tile2"))
        {
            Debug.Log("LOGTHAT: " + other.tag + " PLACED ON BALANCE");
            float weight = 5.0f;
            GetComponentInParent<BalanceScript>().scaleBalance(weight);
        }

    }

    // Inverse FOR ON TRIGGER EXIT

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tile1"))
        {
            Debug.Log("LOGTHAT: " + other.tag + " PLACED ON BALANCE");
            float weight = 10.0f;
            GetComponentInParent<BalanceScript>().scaleBalance(weight*-1.0f);
        }

        if (other.CompareTag("Tile2"))
        {
            Debug.Log("LOGTHAT: " + other.tag + " PLACED ON BALANCE");
            float weight = 5.0f;
            GetComponentInParent<BalanceScript>().scaleBalance(weight * -1.0f);
        }
    }


}


