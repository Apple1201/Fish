using UnityEngine;
using UnityEngine.Video;

public class DisableVideoAfterPlay : MonoBehaviour
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
            videoPlayer.Pause(); // Pause the video instead of destroying or disabling it
        }
    }
}