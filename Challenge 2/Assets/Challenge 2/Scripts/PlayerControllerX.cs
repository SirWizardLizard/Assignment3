/*
 * Zechariah Burrus
 * Assignment 2
 * Lets the player shoot dogs and prevents spam
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float dogTimer = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= dogTimer)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogTimer = Time.time + 1.5f; 
        }
    }
}
