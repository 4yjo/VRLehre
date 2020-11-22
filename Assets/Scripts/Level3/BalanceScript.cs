using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LeftHolder;
    public GameObject RightHolder;
    public GameObject MiddleMove;
    public float scalefactor;
    private Transform oldPosLeft;
    private Transform newPosLeft;
    private Transform oldPosRight;
    private Transform newPosRight;

    
    void Start()
    {
        //set startposition of Holders
        // the float needs to correspond sum of all weights that should
        // be put into balance 
        //scaleBalance(10.0f);
    }

   
    public void scaleBalance(float weight)
    {
       
        Debug.Log("LOGTHAT FUNCTION SCALE BALANCE CALLED");

        //position for left Holder

        oldPosLeft = LeftHolder.transform;
        //update position
        oldPosLeft.position = oldPosLeft.position - new Vector3(0, weight*scalefactor, 0);

        Debug.Log("POSITION" + oldPosLeft.position);

        // position of rightHolder

        oldPosRight = RightHolder.transform;
        //update position
        oldPosRight.position = oldPosRight.position + new Vector3(0, weight * scalefactor, 0);


    }

}
