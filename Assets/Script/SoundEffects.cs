using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource source;
    public AudioClip Negativity;
    public AudioClip Positivity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playsalt()
    {
        source.PlayOneShot(Negativity);
    }

    public void playcorrect()
    {
        source.PlayOneShot(Positivity);
    }

}
