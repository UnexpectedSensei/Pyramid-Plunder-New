using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePlayer : MonoBehaviour
{
    // Reference to the main character's Rigidbody (assuming the main character has a Rigidbody)
    public Rigidbody MainCharacterRigidbody;

    // Variable to track whether the character is frozen
    private bool isCharacterFrozen = false;

    // Timer to count down the freeze duration
    private float freezeTimer = 3.0f;

    // Update is called once per frame
    void Update()
    {
        // Check if the character is frozen
        if (isCharacterFrozen)
        {
            // Decrement the freeze timer
            freezeTimer -= Time.deltaTime;

            // Check if the freeze timer has reached zero
            if (freezeTimer <= 0)
            {
                // Unfreeze the character
                UnfreezeCharacter();
            }
        }
    }

    // Function to freeze the character
    public void FreezeCharacter()
    {
        // Check if the main character's Rigidbody is assigned
        if (MainCharacterRigidbody != null)
        {
            // Disable the Rigidbody's movement and rotation
            MainCharacterRigidbody.velocity = Vector3.zero;
            MainCharacterRigidbody.angularVelocity = Vector3.zero;
            MainCharacterRigidbody.isKinematic = true;
        }

        // Set the character as frozen
        isCharacterFrozen = true;
    }

    // Function to unfreeze the character
    private void UnfreezeCharacter()
    {
        // Check if the main character's Rigidbody is assigned
        if (MainCharacterRigidbody != null)
        {
            // Enable the Rigidbody's movement and rotation
            MainCharacterRigidbody.isKinematic = false;
        }

        // Reset the freeze timer and unfreeze the character
        isCharacterFrozen = false;
        freezeTimer = 3.0f;
    }
}
