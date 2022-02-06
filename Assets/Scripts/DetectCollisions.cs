using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.gameObject.GetComponent<PlayerStats>().getHealth() > 0)
            {
                other.gameObject.GetComponent<PlayerStats>().deleteOneHealth();
                Debug.Log("health: " + other.gameObject.GetComponent<PlayerStats>().getHealth());
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(other.gameObject);
            GetComponent<AnimalStats>().AnimalHungryLevel.value += other.gameObject.GetComponent<FoodStats>().getNutritionalValue();
            if (GetComponent<AnimalStats>().AnimalHungryLevel.value == 100)
            {
                GameObject.FindWithTag("Player").GetComponent<PlayerStats>().addScore(1);
                Destroy(gameObject);
                Debug.Log("score: " + GameObject.FindWithTag("Player").GetComponent<PlayerStats>().getScore());
            }

        }
    }
}
