using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerTrigger : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;

    private bool hasPlayerEntered = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasPlayerEntered)
        {
            hasPlayerEntered = true;
            videoPlayer.Play(); // Autoplay the video when the player enters the trigger area
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasPlayerEntered = false;
            videoPlayer.Stop(); // Stop the video when the player exits the trigger area
        }
    }
}