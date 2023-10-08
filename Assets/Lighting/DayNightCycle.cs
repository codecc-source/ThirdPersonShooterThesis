using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Light sun;
    public float dayCycleInSeconds = 10.0f;
    public float maxIntensity = 1.0f;
    public float minIntensity = 0.0f;
    public float maxAmbientIntensity = 1.0f;
    public float minAmbientIntensity = 0.0f;
    public int scoreThreshold = 100;

    public Material daySkybox;
    public Material nightSkybox;

    private bool isDaytime = true;

    void Start()
    {
        InvokeRepeating("UpdateDayNightCycle", 0.0f, dayCycleInSeconds);
        RenderSettings.skybox = daySkybox;
    }

    void UpdateDayNightCycle()
    {
        if (ScoringScript.score >= scoreThreshold && isDaytime)
        {
            isDaytime = false;
            RenderSettings.ambientIntensity = minAmbientIntensity;
            sun.intensity = minIntensity;

            RenderSettings.skybox = nightSkybox;

            sun.transform.Rotate(240.0f, 0.0f, 0.0f);

            Debug.Log("nighttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttt");
        }
        else if (ScoringScript.score < scoreThreshold && !isDaytime)
        {
            isDaytime = true;
            RenderSettings.ambientIntensity = maxAmbientIntensity;
            sun.intensity = maxIntensity;

            RenderSettings.skybox = daySkybox;

            sun.transform.Rotate(180.0f, 0.0f, 0.0f);

            Debug.Log("dayyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy");
        }
    }
}

