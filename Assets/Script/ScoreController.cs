using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ScoreController : MonoBehaviour
{
    public int Positivity { get; private set; } = 0;
    public int Negativity { get; private set; } = 0;
    //public float postExposureChange = 0.4f;
    public float contrastChange = 10.0f;
    public float saturationChange = 15.0f;


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
        //colorAdjustments.postExposure.value = value * postExposureChange;
        colorAdjustments.saturation.value = value * saturationChange;
    }
}