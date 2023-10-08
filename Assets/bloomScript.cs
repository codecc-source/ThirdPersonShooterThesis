using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class bloomScript : MonoBehaviour
{
    private PostProcessVolume _postProcessVolume;
    private Bloom _bloom;

    public void Start()
    {
        _postProcessVolume = GetComponent<PostProcessVolume>();
        _postProcessVolume.profile.TryGetSettings(out _bloom);
    }

    public void BloomOnOff(bool on)
    {
        if (on)
        {
            _bloom.active = true;
        }
        else
        {
            _bloom.active = false;
        }
    }

    public void Intensity()
    {
        _bloom.intensity.value = 20f;
    }

    public void Threshold()
    {
        _bloom.threshold.value = 20f;
    }

    public void SoftKnee()
    {
        _bloom.softKnee.value = 20f;
    }

    public void Clamp()
    {
        _bloom.clamp.value = 20f;
    }

    public void Diffusion()
    {
        _bloom.diffusion.value = 20f;
    }

    public void AnamorphicRatio()
    {
        _bloom.anamorphicRatio.value = 20f;
    }

    public void fastMode(bool on)
    {
        if (on)
        {
            _bloom.fastMode.value = true;
        }
        else
        {
            _bloom.fastMode.value = false;
        }
    }
}
