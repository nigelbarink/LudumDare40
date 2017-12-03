using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CenveyerBelt : MonoBehaviour
{
    public float ConveyerSpeed = 5f;
    
	void Update ()
	{
	    foreach ( Transform belt in transform )
	    {
	        Vector3 position = belt.transform.position;
	        position.x += ConveyerSpeed * Time.deltaTime;
	        position.x = position.x >= 11f ? -11 : position.x;
	        belt.transform.position = position;

        }

    }
}
