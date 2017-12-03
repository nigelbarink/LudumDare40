using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CenveyerBelt : MonoBehaviour
{
    public float ConveyerSpeed = 5f;
    public GameObject ConveyerBelt;
    public int numberOfConveyerBelts;

    private void OnEnable() {
        for (int i = 0; i < numberOfConveyerBelts; i++) {

            GameObject go = GameObject.Instantiate(ConveyerBelt, new Vector3(-11 + i , 0, 0 ), Quaternion.identity ,this.transform);
            GameManager gm = GameManager.FindObjectOfType<GameManager>();
            Debug.Assert(gm != null, "Could not find a gameManager!" );
            gm.Belt.Add(go);

        }
    }
    
    void Update ()
	{
	    foreach ( Transform belt in transform )
	    {
            Vector3 position = belt.transform.position;
	        position.x += ConveyerSpeed * Time.deltaTime;
	        position.x = position.x >=( this.transform.position + new Vector3(20,-2,0) ).x ? this.transform.position.x : position.x;
	        belt.transform.position = position;

        }

    }
    
}
