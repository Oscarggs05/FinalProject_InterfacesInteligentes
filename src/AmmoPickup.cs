using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public int ammoAmount = 10;

    private void OnTriggerEnter(Collider other)
    {
        Gun gun = other.GetComponentInChildren<Gun>();

        if (gun != null)
        {
            gun.AddAmmo(ammoAmount);
            Destroy(gameObject);
        }
    }
}
