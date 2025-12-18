using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingEnemies : MonoBehaviour
{
    public float jumpForce = 40f; // Fuerza del salto
    public float jumpInterval = 2f; // Cada cuánto saltan

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(JumpRoutine());
    }

    IEnumerator JumpRoutine()
    {
        while (true)
        {
            JumpRandomDirection();
            yield return new WaitForSeconds(jumpInterval);
        }
    }

    void JumpRandomDirection()
    {
        // Generamos una dirección aleatoria en X y Z
        Vector3 randomDirection = new Vector3(Random.Range(-1f, 1f), 1f, Random.Range(-1f, 1f));
        randomDirection.Normalize(); // Normalizamos para que tenga siempre la misma fuerza

        rb.velocity = Vector3.zero; // Reiniciamos la velocidad para saltos consistentes
        rb.AddForce(randomDirection * jumpForce, ForceMode.Impulse);
    }
}
