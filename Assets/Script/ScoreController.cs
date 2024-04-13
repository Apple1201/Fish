using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    public delegate void OnPositivityChanged();
    public static event OnPositivityChanged AddPositivity;
    public delegate void OnNegativityChanged();
    public static event OnNegativityChanged AddNegativity;

}
