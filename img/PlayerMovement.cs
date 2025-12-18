using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    public float sensitivity = 2f; // velocidad de rotación con ratón o mando
    float rotationX = 0f;
    float rotationY = 0f;

    void Update()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 10, Color.red);

        // --- Movimiento ---
        float h = Input.GetAxis("Horizontal"); // A/D, izquierda/derecha o joystick X
        float v = Input.GetAxis("Vertical");   // W/S, arriba/abajo o joystick Y

        Vector3 move = transform.right * h + transform.forward * v;
        move.y = 0f; // bloquea Y para no mover al jugador verticalmente
        transform.position += move * speed * Time.deltaTime;

        // --- Rotación ---
        float lookX = Input.GetAxis("Mouse X"); // ratón o joystick derecho X
        float lookY = Input.GetAxis("Mouse Y"); // ratón o joystick derecho Y

        // Ajustamos sensibilidad
        rotationY += lookX * sensitivity;
        rotationX -= lookY * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -80f, 80f);

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);
    }
}
