using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerTrigger : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private GameObject videoGameObject;

    private bool hasPlayerEntered = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasPlayerEntered)
        {
            hasPlayerEntered = true;
            videoGameObject.SetActive(true); // Enable the video GameObject when the player enters the trigger area
            videoPlayer.Play(); // Start playing the video
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasPlayerEntered = false;
            videoPlayer.Stop(); // Stop the video when the player exits the trigger area
            videoGameObject.SetActive(false); // Disable the video GameObject
        }
    }
}