using UnityEngine;
using UnityEngine.Video;

public class DestroyVideoAfterPlay : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        if (vp == videoPlayer)
        {
            Destroy(gameObject); // Destroy the GameObject after the video has finished playing
        }
    }
}