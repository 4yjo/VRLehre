using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyTeleportTut : MonoBehaviour
{
    public GameObject ToBeDestroyed; //put Game Object you want to have destroyed on button click to this variable in inspector
    void OnTriggerEnter()
    {

        Destroy(ToBeDestroyed);
        SceneManager.LoadScene("workingComputerII");

    }

    private void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp))
        {
            Destroy(ToBeDestroyed);
            SceneManager.LoadScene("workingComputerII");
        }
    }

}
