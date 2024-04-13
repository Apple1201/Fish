using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NegativityUI : MonoBehaviour
{
    private TMP_Text _negativityText;

    private void Awake()
    {
        _negativityText = GetComponent<TMP_Text>();
    }

    public void UpdateNegativity(ScoreManager scoreManager)
    {
        _negativityText.text = $"{scoreManager.Negativity} / 3";
    }
}
