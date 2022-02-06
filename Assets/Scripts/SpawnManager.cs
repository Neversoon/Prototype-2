using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRangeX = 21;
    private float spawnRangeUp = 15;
    private float spawnRangeDown = 0;
    private float spawnSharedAxis = 20;
    private float startDelay = 2.0f;
    private float spawnInterval = 2.0f;
    private float[] animalTurn = new float[3] { -90.0f, 180.0f, 90.0f };
    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int animalRotationIndex = Random.Range(0, animalTurn.Length);
        animalPrefabs[animalIndex].transform.eulerAngles = new Vector3(0,animalTurn[animalRotationIndex],0);
        Vector3 spawnPos = new Vector3(0,0,0);
        
        if(animalRotationIndex == 1){
            spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnSharedAxis); 
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
        if(animalRotationIndex == 0){
            spawnPos = new Vector3(spawnSharedAxis, 0, Random.Range(spawnRangeDown, spawnRangeUp));
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
        if(animalRotationIndex == 2){
            spawnPos = new Vector3(-spawnSharedAxis, 0, Random.Range(spawnRangeDown, spawnRangeUp));
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
        
    }
}
