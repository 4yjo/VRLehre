using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//following tutorial https://www.youtube.com/watch?v=3cJ_uq1m-dg
// this script overwrites Grabber so that on leving the object the
//black box is going back to its originate position

public class DoorGrabber : OVRGrabbable
{
    public Transform handler;

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
      base.GrabEnd(Vector3.zero, Vector3.zero);
      transform.position = handler.transform.position;
      transform.rotation = handler.transform.rotation;  
    }

    private void Update()
    {
        if(Vector3.Distance(handler.position, transform.position)> 0.4f)
        {
            grabbedBy.ForceRelease(this);
        }
    }
}
