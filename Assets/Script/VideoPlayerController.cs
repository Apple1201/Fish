using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public GameObject goodEndVideo;
    public GameObject badEndVideo;
    public ScoreController scoreController;

    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Player") && (scoreController.Positivity + scoreController.Negativity == 3))
        {
            goodEndVideo.SetActive(true);
            badEndVideo.SetActive(true);
            goodEndVideo.GetComponent<VideoPlayer>().Play();
            badEndVideo.GetComponent<VideoPlayer>().Play();
            hasTriggered = true;
        }
    }

    private void Update()
    {
        if (hasTriggered)
        {
            if (scoreController.Positivity > scoreController.Negativity)
            {
                goodEndVideo.SetActive(true);
                badEndVideo.SetActive(false);
                goodEndVideo.GetComponent<VideoPlayer>().Play();
            }
            else if (scoreController.Negativity > scoreController.Positivity)
            {
                goodEndVideo.SetActive(false);
                badEndVideo.SetActive(true);
                badEndVideo.GetComponent<VideoPlayer>().Play();
            }
        }
    }
}