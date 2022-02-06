/*
 * Zechariah Burrus
 * Assignment 2
 * Spawns the designated prefabs randomly with specified bounds and time constraints.
 * Also stops spawning balls when game is won or game is over.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    public HealthSystem healthSystem;
    public DisplayScore displayScore;


    // Start is called before the first frame update
    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        displayScore = GameObject.FindGameObjectWithTag("DisplayScore").GetComponent<DisplayScore>();
        StartCoroutine(SpawnRandomBallWithCoroutine());
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int randomBallIndex = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBallIndex], spawnPos, ballPrefabs[randomBallIndex].transform.rotation);
    }

    IEnumerator SpawnRandomBallWithCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while (!healthSystem.gameOver && !displayScore.gameWon)
        {
            SpawnRandomBall();

            float randomDelay = Random.Range(3f, 5f);

            yield return new WaitForSeconds(randomDelay);
        }
    }
}