using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 InputPlayer;
    private float speed = 20.0f; 
    private float xRange = 21.5f;
    private float upRange = 16.5f;
    private float downRange = -2.0f;
    public GameObject projectilePrefab;
    // Update is called once per frame
    void Update()
    {
        InputPlayer.x = Input.GetAxis("Horizontal");
        InputPlayer.z = Input.GetAxis("Vertical");
        if(transform.position.x < -xRange){
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z); 
        }
        if(transform.position.x > xRange){
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z); 
        }
        if(transform.position.z < downRange){
            transform.position = new Vector3(transform.position.x,transform.position.y,downRange); 
        }
        if(transform.position.z > upRange){
            transform.position = new Vector3(transform.position.x,transform.position.y,upRange); 
        }
        transform.Translate(InputPlayer * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space)) {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
