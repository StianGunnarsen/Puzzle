using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endQuit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Log when something enters the trigger zone
        Debug.Log("Trigger entered by: " + other.gameObject.name);

        // Check if the object that entered the trigger has the "Player" tag
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered, quitting application...");

            // Quit the application
            Application.Quit();

            // If running in the editor, stop the play mode
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }
    }
            
}

