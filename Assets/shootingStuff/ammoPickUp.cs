using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoPickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth healthPickUp = other.gameObject.GetComponent<PlayerHealth>();
        RifleShooterController RiflePickUp = other.gameObject.GetComponent<RifleShooterController>();
        PistolShooterController PistolPickUp = other.gameObject.GetComponent<PistolShooterController>();

        if (RiflePickUp || PistolPickUp || healthPickUp )
        {
            Destroy(gameObject);
            RiflePickUp.addAmmo(RiflePickUp.maxAmmo);
            PistolPickUp.addAmmo(PistolPickUp.maxAmmo);
            healthPickUp.AddHealth(20);
        }
    }
}
