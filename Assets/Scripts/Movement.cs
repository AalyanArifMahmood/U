using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 8f; // Movement speed
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to this GameObject
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = Vector2.zero; // Initialize movement vector to zero

        // Check for vertical movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement.y = speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            movement.y = -speed;
        }

        // Check for horizontal movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.x = speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x = -speed;
        }

        // Apply the movement to the Rigidbody2D component
        rigidBody.velocity = movement;
    }
}
