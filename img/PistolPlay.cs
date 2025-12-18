using System.Diagnostics;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PistolPLay : MonoBehaviour
{
    public Gun gun;
    public float interactDistance = 100f; // distancia máxima para el raycast

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Fire1"))
        {
            Camera cam = Camera.main;
            Vector3 forward = cam.transform.forward;
            Vector3 rayOrigin = cam.transform.position;

            // 2️⃣ Disparo de la bala siempre hacia el frente de la cámara
            Vector3 shootTarget = rayOrigin + forward * interactDistance;
            gun.Shoot(shootTarget);
        }
    }
}
