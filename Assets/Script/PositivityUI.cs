using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PositivityUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI positivityText;

    ScoreController scoreController;
    private void Start()
    {
        scoreController = GameObject.FindGameObjectWithTag("ScoreController").GetComponent<ScoreController>();
        positivityText.text = scoreController.Positivity + " / 3";
        //UpdatePositivity();
    }

    public void UpdatePositivity()
    {
        scoreController.AddPositivity();
        positivityText.text = scoreController.Positivity + " / 3";
    }
}
