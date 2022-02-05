using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    //contains all spawnable prefab objects
    public GameObject[] prefabsToSpawn;

    //Bounds for where to spawn objects
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    //Gameover value
    public bool gameOver = false;

    void Start() {
        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.S)) {
            SpawnRandomPrefab();
        }
    }

    void SpawnRandomPrefab() {
        //Generate a random prefab to spawn
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        //Generate random spawn position within bounds
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        //Instantiate prefabs at designated positions
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }

    IEnumerator SpawnRandomPrefabWithCoroutine() {
        //3 second delay before the first prefab spawns
        yield return new WaitForSeconds(3f);

        //While the game isn't over continue spawning prefabs every 1.5 seconds
        while(!gameOver) {
            SpawnRandomPrefab();

            float randomDelay = Random.Range(.5f, 1.5f);

            yield return new WaitForSeconds(randomDelay);
        }
    }
}
