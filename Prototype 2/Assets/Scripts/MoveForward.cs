/*
 * Zechariah Burrus
 * Assignment 2
 * Causes gameObjects to move forward at a specific speed
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {
    public float speed = 40;

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
