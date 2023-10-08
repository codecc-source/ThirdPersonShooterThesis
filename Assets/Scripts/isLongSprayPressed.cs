using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isLongSprayPressed : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
