using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressureplate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("box"))
        {
            GameObject obstacle = GameObject.FindWithTag("obstacle");

            if (obstacle != null)
            {
                Destroy(obstacle);
            }
        }
    }
}
