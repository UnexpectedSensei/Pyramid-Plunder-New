using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust this value to control movement speed.
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Input for player movement.
        float horizontalInput = Input.GetAxis("Horizontal"); // A/D or Left/Right arrow keys
        float verticalInput = Input.GetAxis("Vertical");     // W/S or Up/Down arrow keys

        // Calculate the movement vector.
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        // Normalize the vector to prevent faster diagonal movement.
        movement.Normalize();

        // Apply the movement to the Rigidbody.
        rb.velocity = transform.TransformDirection(movement) * moveSpeed;
    }
}
