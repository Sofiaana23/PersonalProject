using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour

{
    public GameObject[] environmentObjects;
    private float zFoodSpawn = 12.0f;
    private float xSpawnRange = 16.0f;
    private float ySpawn = 0.75f;

    public float sleepTime = 1f;
    private float currentSleep = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObjects();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSleep <= 0f){
            SpawnObjects();
            currentSleep = Random.Range(0,sleepTime);
        }
        else {
            currentSleep -= Time.deltaTime;
        }
    }

    void SpawnObjects ()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, environmentObjects.Length);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zFoodSpawn);

        Instantiate(environmentObjects[randomIndex], spawnPos, environmentObjects[randomIndex].gameObject.transform.rotation);
    }
}

