using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rifleMeterRefill : MonoBehaviour
{
    public RifleShooterController rifleammo;
    private int rifleAmmo2;

    public Slider rifleammoMeter;

    private void Start()
    {
        if (rifleammo)
        {
            rifleAmmo2 = rifleammo.maxAmmo;
            rifleammoMeter.maxValue = rifleAmmo2;
        }
        else
        {
            return;
        }
    }
    private void Update()
    {
        if (rifleammo)
        {
            rifleammoMeter.value = rifleammo.currentAmmo;
            Debug.Log(rifleammo.currentAmmo);
        }
    }
}
