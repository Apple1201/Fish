using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositivityUI : MonoBehaviour
{
    private Text _positivityText;

    private void Awake()
    {
        _positivityText = GetComponent<Text>();
    }

    public void UpdatePositivity(ScoreManager scoreManager)
    {
        _positivityText.text = $"{scoreManager.Positivity} / 3";
    }
}
