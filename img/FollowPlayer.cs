using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject jugador; 

    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindWithTag("Player");
        UnityEngine.Debug.Log(jugador.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(jugador.transform);
        transform.position = Vector3.MoveTowards(transform.position, jugador.transform.position, 15f * Time.deltaTime);
    }
}
