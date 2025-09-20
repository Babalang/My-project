// 19/09/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateWithInput : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 50f; // Speed of rotation in degrees per second

    void Update()
    {
        // Check if the left arrow key is pressed
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            // Rotate the GameObject to the left (negative y-axis rotation)
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        // Check if the right arrow key is pressed
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            // Rotate the GameObject to the right (positive y-axis rotation)
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
