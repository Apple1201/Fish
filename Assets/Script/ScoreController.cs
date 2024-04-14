using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;


public class ScoreController : MonoBehaviour
{
    public int Positivity { get; private set; } = -1;
    public int Negativity { get; private set; } = -1;
    public float contrastChange = 30.0f; // Amount of contrast change per score increase
    public float postExposureChange = 2.0f;
    public float saturationChange = 30.0f;

    ScoreController scoreController;
    Volume postProcessingVolume;
    ColorAdjustments colorAdjustments;

    void Start()
    {
        scoreController = GameObject.FindGameObjectWithTag("ScoreController").GetComponent<ScoreController>();
        postProcessingVolume = FindObjectOfType<Volume>();
        postProcessingVolume.profile.TryGet(out colorAdjustments);
    }


    public void AddPositivity()
    {
        Positivity++;
    }
    public void AddNegativity()
    {
        Negativity++;
    }

    public void Update()
    {
        if (Positivity >= 0 && Negativity >= 0 && Positivity - Negativity == 1)
        {
            colorAdjustments.contrast.value = scoreController.Positivity * contrastChange;
            colorAdjustments.postExposure.value = scoreController.Positivity * postExposureChange;
            colorAdjustments.saturation.value = scoreController.Positivity * saturationChange;
            Debug.Log("Bright color 1 occured!");
        }
        else if (Positivity >= 0 && Negativity >= 0 && Positivity - Negativity == 2)
        {
            colorAdjustments.contrast.value = scoreController.Positivity * contrastChange;
            colorAdjustments.postExposure.value = scoreController.Positivity * postExposureChange;
            colorAdjustments.saturation.value = scoreController.Positivity * saturationChange;
            Debug.Log("Bright color 2 occured!");
        }
        else if (Positivity >= 0 && Negativity >= 0 && Positivity - Negativity == 3)
        {
            colorAdjustments.contrast.value = scoreController.Positivity * contrastChange;
            colorAdjustments.postExposure.value = scoreController.Positivity * postExposureChange;
            colorAdjustments.saturation.value = scoreController.Positivity * saturationChange;
            Debug.Log("Bright color 3 occured!");
        }
        else if (Negativity >= 0 && Positivity >= 0 && Negativity - Positivity == 1)
        {
            colorAdjustments.contrast.value = -scoreController.Negativity * contrastChange;
            colorAdjustments.postExposure.value = -scoreController.Negativity * postExposureChange;
            colorAdjustments.saturation.value = -scoreController.Negativity * saturationChange;
            Debug.Log("Dull color 1 occured!");
        }
        else if (Negativity >= 0 && Positivity >= 0 && Negativity - Positivity == 2)
        {
            colorAdjustments.contrast.value = -scoreController.Negativity * contrastChange;
            colorAdjustments.postExposure.value = -scoreController.Negativity * postExposureChange;
            colorAdjustments.saturation.value = -scoreController.Negativity * saturationChange;
            Debug.Log("Dull color 2 occured!");
        }
        else if (Negativity >= 0 && Positivity >= 0 && Negativity - Positivity == 3)
        {
            colorAdjustments.contrast.value = -scoreController.Negativity * contrastChange;
            colorAdjustments.postExposure.value = -scoreController.Negativity * postExposureChange;
            colorAdjustments.saturation.value = -scoreController.Negativity * saturationChange;
            Debug.Log("Dull color 3 occured!");
        }
        else
        {
            return;
        }
    }
}
