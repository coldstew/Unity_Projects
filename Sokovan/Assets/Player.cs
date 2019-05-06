using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public float speed = 10f;
    private Rigidbody playerRigidbody; // it's private to prevent any differences


    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (gameManager.isGameOver == true)
        {
            return;
        }
        // A <-            -> D
        // -1.0      0     +1.0
        
        float inputX = Input.GetAxis("Horizontal");
        
        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = playerRigidbody.velocity.y;

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        
        velocity = velocity * speed;

        velocity.y = fallSpeed;

        playerRigidbody.velocity = velocity;

        /* if (Input.GetKey(KeyCode.W))
        {
            playerRigidbody.AddForce(0,0,speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerRigidbody.AddForce(-speed,0,0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerRigidbody.AddForce(0,0,-speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerRigidbody.AddForce(speed,0,0);
        } */
    }
}
