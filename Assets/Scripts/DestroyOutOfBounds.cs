using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float rightAndLeftBounds = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If object goes past the player view, remove that object 
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
            GameObject.FindWithTag("Player").GetComponent<PlayerStats>().deleteOneHealth();
        }
        else if (transform.position.z < lowerBound )
        {
            Destroy(gameObject);
            GameObject.FindWithTag("Player").GetComponent<PlayerStats>().deleteOneHealth();
        }
        else if (transform.position.x > rightAndLeftBounds)
        {
            Destroy(gameObject);
            GameObject.FindWithTag("Player").GetComponent<PlayerStats>().deleteOneHealth();
        }
        else if (transform.position.x < -rightAndLeftBounds)
        {
            Destroy(gameObject);
            GameObject.FindWithTag("Player").GetComponent<PlayerStats>().deleteOneHealth();
        }
    }
}
