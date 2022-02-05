using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour {
    public float topbound = 20;
    public float bottombound = -10;

    // Update is called once per frame
    void Update() {
        if(transform.position.z > topbound) {
            Destroy(gameObject);
        }

        if(transform.position.z < bottombound) {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    } 
}
