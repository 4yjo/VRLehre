using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateDoor : MonoBehaviour
{
    public bool activated;
    Collider letsOpen;

    void Start(){
        letsOpen = GetComponent<Collider>();
    }
    // Update is called once per frame
    void Update()
    {
        if (activated){
            letsOpen.enabled = !letsOpen.enabled;
        }
    }
}
