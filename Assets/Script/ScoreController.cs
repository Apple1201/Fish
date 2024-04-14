using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int Positivity { get; private set; } = -1;
    public int Negativity { get; private set; } = -1;


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
            ////post-processing/////
            Debug.Log("Bright color 1 occured!");
        }
        else if (Positivity >= 0 && Negativity >= 0 && Positivity - Negativity == 2)
        {
            ////post-processing/////
            Debug.Log("Bright color 2 occured!");
        }
        else if (Positivity >= 0 && Negativity >= 0 && Positivity - Negativity == 3)
        {
            ////post-processing/////
            Debug.Log("Bright color 3 occured!");
        }
        else if (Negativity >= 0 && Positivity >= 0 && Negativity - Positivity == 1)
        {
            ////post-processing/////
            Debug.Log("Dull color 1 occured!");
        }
        else if (Negativity >= 0 && Positivity >= 0 && Negativity - Positivity == 2)
        {
            ////post-processing/////
            Debug.Log("Dull color 2 occured!");
        }
        else if (Negativity >= 0 && Positivity >= 0 && Negativity - Positivity == 3)
        {
            ////post-processing/////
            Debug.Log("Dull color 3 occured!");
        }
        else
        {
            return;
        }
    }
}
