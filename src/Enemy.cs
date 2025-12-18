using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour
{
    // Evento que se dispara al morir
    public static event Action<Enemy> OnEnemyKilled;

    private void OnCollisionEnter(Collision collision)
    {
        // Comprobamos si ha sido golpeado por una bala
        if (collision.gameObject.CompareTag("Bullet"))
        {
            KillEnemy();
        }
    }

    private void KillEnemy()
    {
        // Disparamos el evento
        OnEnemyKilled?.Invoke(this);

        // Destruir el enemigo
        Destroy(gameObject);
    }
}
