using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NegativityUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI negativityText;
    //public AudioSource source;
    //public AudioClip clip;
    ScoreController scoreController;
    private void Start()
    {
        scoreController = GameObject.FindGameObjectWithTag("ScoreController").GetComponent<ScoreController>();
        negativityText.text = scoreController.Negativity + " / 3";
        //UpdateNegativity();
    }

    public void UpdateNegativity()
    {
        scoreController.AddNegativity();
        //source.PlayOneShot(clip);
        negativityText.text = scoreController.Negativity + " / 3";
    }
}