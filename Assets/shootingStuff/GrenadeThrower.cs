using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrower : MonoBehaviour
{
    public float throwForce = 20f;
    public GameObject grenadePrefab;
    public int GrenadeAmmo = 8;
    public int maxGrenade = 8;

    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            if (GrenadeAmmo > 0)
            {
                ThrowGrenade();
                GrenadeAmmo--;
            }
            else
            {
                Debug.Log("No Grenade");
            }
        }
    }
    void ThrowGrenade()
    {
        GameObject grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward*throwForce, ForceMode.VelocityChange);
    }

    /*public void addGrenade(int grenadeAmount)
    {
        GrenadeAmmo += maxGrenade;
        if (GrenadeAmmo > maxGrenade)
        {
            GrenadeAmmo = maxGrenade;
        }
    }*/
}
