using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    public int Positivity = 0;
    public int Negativity = 0;

    private void OnEnable()
    {
        ScoreController.AddPositivity += PositivityIncreased;
        ScoreController.AddNegativity += NegativityIncreased;
    }
    private void OnDisable()
    {
        ScoreController.AddPositivity -= PositivityIncreased;
        ScoreController.AddPositivity -= NegativityIncreased;
    }

    public void PositivityIncreased()
    {
        Positivity += 1;
        Debug.Log("So positive!");
    }

    public void NegativityIncreased()
    {
        Negativity += 1;
        Debug.Log("So negative!");
    }
}
