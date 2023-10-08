using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pistolMeterRefill : MonoBehaviour
{
    public PistolShooterController pistolammo;
    private int pistolAmmo2;

    public Slider pistolammoMeter;

    private void Start()
    {
        if (pistolammo)
        {
            pistolAmmo2 = pistolammo.maxAmmo;
            pistolammoMeter.maxValue = pistolAmmo2;
        }
        else
        {
            return;
        }
    }
    private void Update()
    {
        if (pistolammo)
        {
            pistolammoMeter.value = pistolammo.currentAmmo;
            Debug.Log(pistolammo.currentAmmo); 
        }
    }
}
