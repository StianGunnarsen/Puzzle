using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTriggerTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detected by: " + other.gameObject.name);
    }
}
