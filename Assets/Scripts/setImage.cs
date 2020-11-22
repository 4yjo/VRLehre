using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setImage : MonoBehaviour {
[SerializeField] private UnityEngine.UI.Image image = null;

private void Awake()
{
    if( image != null )
    {
        image.sprite = Resources.Load<Sprite>( "testbild" );
    }
}
}