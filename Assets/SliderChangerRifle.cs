using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderChangerRifle : MonoBehaviour
{
    public Slider ammoSlider;
    public int ammoThreshold = 100;
    public Color lowAmmoColor = Color.red;
    public Color normalAmmoColor = Color.green;
    public TextMeshProUGUI ammoText;

    void Update()
    {
        if (ammoSlider.value < ammoThreshold)
        {
            ammoSlider.fillRect.GetComponent<Image>().color = lowAmmoColor;
            ammoText.enabled = true;
        }
        else
        {
            ammoSlider.fillRect.GetComponent<Image>().color = normalAmmoColor;
            ammoText.enabled = false;
        }
    }
}