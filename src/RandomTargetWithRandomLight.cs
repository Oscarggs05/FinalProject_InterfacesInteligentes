using System.Collections;
using UnityEngine;
using System;

public class RandomTargetWithRandomLight : MonoBehaviour
{
    [Header("Tiempos de aparición")]
    public float minVisibleTime = 1f;
    public float maxVisibleTime = 3f;
    public float minHiddenTime = 1f;
    public float maxHiddenTime = 3f;

    [Header("Componentes")]
    public Light targetLight; // Cada bola tiene su propia luz

    private Renderer rend;
    private Collider col;

    [Header("Colores posibles de la luz")]
    public Color[] possibleColors = { Color.white, Color.red, Color.green, Color.blue, Color.yellow };

    void Start()
    {
        rend = GetComponent<Renderer>();
        col = GetComponent<Collider>();

        // Inicialmente apagamos todo
        rend.enabled = false;
        if (col != null) col.enabled = false;
        if (targetLight != null) targetLight.enabled = false;

        // Iniciamos la corrutina independiente para esta bola
        StartCoroutine(AppearDisappearCycle());
    }

    private IEnumerator AppearDisappearCycle()
    {
        while (true)
        {
            // Aparece
            rend.enabled = true;
            if (col != null) col.enabled = true;

            if (targetLight != null)
            {
                targetLight.enabled = true;

                // Escoger un color aleatorio para ESTA luz
                if (possibleColors.Length > 0)
                {
                    int index = UnityEngine.Random.Range(0, possibleColors.Length);
                    targetLight.color = possibleColors[index];
                }
            }

            float visibleDuration = UnityEngine.Random.Range(minVisibleTime, maxVisibleTime);
            yield return new WaitForSeconds(visibleDuration);

            // Desaparece
            rend.enabled = false;
            if (col != null) col.enabled = false;
            if (targetLight != null) targetLight.enabled = false;

            float hiddenDuration = UnityEngine.Random.Range(minHiddenTime, maxHiddenTime);
            yield return new WaitForSeconds(hiddenDuration);
        }
    }

    // --- Integración con tu Enemy ---
    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Bullet"))
    //     {
    //         KillEnemy();
    //     }
    // }

    // private void KillEnemy()
    // {
    //     Enemy.OnEnemyKilled?.Invoke(GetComponent<Enemy>());
    //     Destroy(gameObject);
    // }
}
