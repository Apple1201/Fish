using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ScoreController : MonoBehaviour
{
    public int Positivity { get; private set; } = -1;
    public int Negativity { get; private set; } = -1;
    public float contrastChange = 30.0f;
    public float postExposureChange = 2.0f;
    public float saturationChange = 30.0f;


    Volume postProcessingVolume;
    ColorAdjustments colorAdjustments;


    void Start()
    {
        postProcessingVolume = FindObjectOfType<Volume>();
        postProcessingVolume.profile.TryGet(out colorAdjustments);
    }

    public void AddPositivity()
    {
        Positivity++;
        UpdatePostProcessingValues();
    }

    public void AddNegativity()
    {
        Negativity++;
        UpdatePostProcessingValues();
    }

    void UpdatePostProcessingValues()
    {
        int value = Positivity - Negativity;

        if (value >= 0)
        {
            UpdateValues(value);
            Debug.Log("Bright color " + (value + 1) + " occurred!");
        }
        else
        {
            UpdateValues(value);
            Debug.Log("Dull color " + (-value + 1) + " occurred!");
        }
    }

    void UpdateValues(int value)
    {
        colorAdjustments.contrast.value = value * contrastChange;
        colorAdjustments.postExposure.value = value * postExposureChange;
        colorAdjustments.saturation.value = value * saturationChange;
    }
}