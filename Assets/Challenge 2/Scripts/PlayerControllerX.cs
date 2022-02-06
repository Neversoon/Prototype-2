using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float oldSpawnTime = -2.5f;
    private float spawnInterval = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        float spawnTime = Time.time;
        if (Input.GetKeyDown(KeyCode.Space) && (spawnTime - oldSpawnTime > spawnInterval)) 
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            oldSpawnTime = spawnTime;
        }
    }
}
