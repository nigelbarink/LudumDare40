using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public List <GameObject>  Belt;
    public float NuclearThreat = 0;
    public float MaxNuclearThreat;
    public GameObject[] Threat;
    void Start () {
        int rng = Random.Range(0, Belt.Capacity - 1);
        Debug.Log(rng + " from " + Belt.Capacity);
        Transform parent = Belt[rng].transform.GetChild(0).transform;
        GameObject.Instantiate(Threat[0], Vector3.zero, Quaternion.identity, parent);

	}
	
	void Update () {
		
	}
}
