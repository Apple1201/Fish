using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NegativityUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI negativityText;

    ScoreController scoreController;
    private void Start()
    {
        scoreController = GameObject.FindGameObjectWithTag("ScoreController").GetComponent<ScoreController>();
        UpdateNegativity();
    }

    public void UpdateNegativity()
    {
        scoreController.AddNegativity();
        negativityText.text = scoreController.Negativity + " / 3";
    }
}