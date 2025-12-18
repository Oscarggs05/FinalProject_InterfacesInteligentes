using UnityEngine;

public class IntroCameraMove : MonoBehaviour
{
    public Transform target;          // jugador
    public Camera playerCamera;       // cámara FPS del jugador
    public float rotationRadius = 20f; // distancia de la cámara al jugador
    public float rotationHeight = 10f; // altura de la cámara durante la vuelta
    public float rotationSpeed = 90f; // grados por segundo
    public float approachDuration = 2f; // tiempo para acercarse al FPS

    private bool isRotating = true;
    private float rotationAngle = 0f;
    private Vector3 endPos;           // posición final: cámara FPS
    private float approachTimer = 0f;

    void Start()
    {
        // Desactivar cámara FPS al inicio
        playerCamera.enabled = false;

        // Posición inicial detrás del jugador
        Vector3 behindOffset = -target.forward * rotationRadius + Vector3.up * rotationHeight;
        transform.position = target.position + behindOffset;

        // Posición final: cámara FPS
        endPos = playerCamera.transform.position;
    }

    void Update()
    {
        if (isRotating)
        {
            // Rotación alrededor del jugador (manteniendo la cámara detrás)
            rotationAngle += rotationSpeed * Time.deltaTime;
            float rad = rotationAngle * Mathf.Deg2Rad;

            // La cámara gira horizontalmente alrededor del jugador, pero manteniendo detrás
            Vector3 offset = new Vector3(Mathf.Sin(rad), 0, Mathf.Cos(rad)) * rotationRadius;
            offset.y = rotationHeight;

            // Ajuste para que la rotación comience detrás del jugador
            offset = Quaternion.LookRotation(-target.forward) * offset;

            transform.position = target.position + offset;
            transform.LookAt(target.position + Vector3.up * 1.5f);

            // Una vuelta completa (360°)
            if (rotationAngle >= 360f)
            {
                isRotating = false;
                approachTimer = 0f;
            }
        }
        else
        {
            // Acercamiento hacia la cámara FPS desde atrás
            approachTimer += Time.deltaTime;
            float t = Mathf.Clamp01(approachTimer / approachDuration);
            transform.position = Vector3.Lerp(transform.position, endPos, t);

            transform.LookAt(target.position + Vector3.up * 1.5f);

            if (t >= 1f)
            {
                // Termina la intro
                playerCamera.enabled = true;
                gameObject.SetActive(false);
            }
        }
    }
}
