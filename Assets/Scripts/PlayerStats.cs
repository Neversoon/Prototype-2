using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private int health = 3;
    private int score = 0;
    private bool GameOver = false;
    // Start is called before the first frame update
    private GameObject SpawnManager;
    void Start()
    {
        Debug.Log("health: " + health);
        Debug.Log("score: " + score);
        SpawnManager = GameObject.Find("SpawnManager");
    }
    void Update(){
        if(GameOver == true){
            Destroy(SpawnManager);
            GetComponent<PlayerController>().enabled = false;
        }
    }
    public bool GameStatus(){
        return GameOver;
    }
    public int getHealth()
    {
        return health;
    }
    public void deleteOneHealth()
    {
        if (GameOver == false)
        {
            health--;
            Debug.Log("health: " + health);
            if (health == 0)
            {
                GameOver = true;
                Debug.Log("Game Over");
            }
        }
    }
    public int getScore()
    {
        return score;
    }
    public void addScore(int ScoreCount)
    {
        if (GameOver == false)
        {
            if (ScoreCount <= 0)
            {
                Debug.Log("added score is shouldn't ben 0 or less than 0");
            }
            else
            {
                score += ScoreCount;
            }
        }
    }
}
