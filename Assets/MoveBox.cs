using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Move the box forward on the X axis
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
