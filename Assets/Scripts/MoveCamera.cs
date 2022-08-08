using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    float cameraSpeed = 10;

    void Update() // move camera with arrow keys
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 input = new Vector3(horizontal, 0, vertical);
        transform.Translate(input * Time.deltaTime * cameraSpeed, Space.World);
    }
}
