using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Hide and lock the cursor
        Cursor.visible = false;
    }
    private void Awake()
    {
        GetComponent<PistolShooterController>().enabled = true;
        GetComponent<RifleShooterController>().enabled = false;
    }
    void Update()
    {
        if (Input.GetKeyDown("1")){
            GetComponent<RifleShooterController>().enabled = false;
            GetComponent<PistolShooterController>().enabled = true;
        }
        else if (Input.GetKeyDown("2"))
        {
            GetComponent<RifleShooterController>().enabled = true;
            GetComponent<PistolShooterController>().enabled = false;
        }
    }
}
