using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour

{
    public GameObject[] food;
    public GameObject enemies;

    private float zFoodSpawn = 12.0f;
    private float xSpawnRange = 16.0f;
    private float zEnemiesRange = 5.0f;
    private float ySpawn = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnFood();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnFood ()
    {
        float randomX = randomX.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = randomIndex.Range(0, food.Lenght);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zFoodSpawn);

        Instantiate(food[randomIndex], spawnPos, food[randomIndex].gameObject.transform.rotation);
    }
}

