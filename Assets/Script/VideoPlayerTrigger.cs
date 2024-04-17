using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;

public class VideoPlayerTrigger : MonoBehaviour
{


    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private GameObject videoGameObject;
    [SerializeField] private VideoPlayer videoPlayerReply;
    [SerializeField] private GameObject videoGameObjectReply;
    [SerializeField] private VideoPlayer videoPlayerReject;
    [SerializeField] private GameObject videoGameObjectReject;

    private bool hasPlayerEntered = false;
    public bool reply = false;
    public bool reject = false;

    public UnityEvent ChooseReplyReject;

    public void PlayReply()
    {
        reply = true;
    }
    public void PlayReject()
    {
        reject = true;
    }
    void OnTriggerEnter(Collider other)
    {
        if (reply)
        {
            videoGameObject.SetActive(false); // Enable the video GameObject when the player enters the trigger area
            videoPlayer.Stop(); // Start playing the video
            videoGameObjectReply.SetActive(true); // Enable the video GameObject when the player enters the trigger area
            videoPlayerReply.Play(); // Start playing the video
        }
        else if (reject)
        {
            videoGameObject.SetActive(false); // Enable the video GameObject when the player enters the trigger area
            videoPlayer.Stop(); // Start playing the video
            videoGameObjectReject.SetActive(true); // Enable the video GameObject when the player enters the trigger area
            videoPlayerReject.Play(); // Start playing the video
        }
        else if (other.CompareTag("Player") && !hasPlayerEntered)
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
            reply = false;
            reject = false;
            videoPlayer.Stop(); // Stop the video when the player exits the trigger area
            videoGameObject.SetActive(false); // Disable the video GameObject
            videoPlayerReply.Stop(); // Stop the video when the player exits the trigger area
            videoGameObject.SetActive(false); // Disable the video GameObject
            videoPlayerReject.Stop(); // Stop the video when the player exits the trigger area
            videoGameObject.SetActive(false); // Disable the video GameObject
        }
    }


}