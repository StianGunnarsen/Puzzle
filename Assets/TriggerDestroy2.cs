using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestroy2 : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D other)
    {
        // Log if the trigger zone is being entered
        Debug.Log("Trigger entered by: " + other.gameObject.name);

        // Check if the object that entered the trigger has the "box" tag
        if (other.CompareTag("box"))
        {
            Debug.Log("Box entered, destroying obstacles...");

            // Find all objects with the "obstacle2" tag
            GameObject[] obstacles = GameObject.FindGameObjectsWithTag("obstacle2");

            // Loop through the found obstacles
            foreach (GameObject obstacle in obstacles)
            {
                // Destroy each obstacle
                Destroy(obstacle);
            }
        }
    }
}


