using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droppable : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision.gameObject.name);
    }

}
