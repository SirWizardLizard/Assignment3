/*
 * Zechariah Burrus
 * Assignment 2
 * Destroys objects that are out of bounds and takes damage when an animal passes the player.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour {
    public float topbound = 20;
    public float bottombound = -10;

    private HealthSystem healthSystemScript;

    void Start() {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update() {
        if(transform.position.z > topbound) {
            Destroy(gameObject);
        }

        if(transform.position.z < bottombound) {
            //Take damage
            healthSystemScript.TakeDamage();
            Destroy(gameObject);
        }
    } 
}
