using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;

public class VideoPlayerTrigger1 : MonoBehaviour
{


    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private GameObject videoGameObject;

    [SerializeField] private VideoPlayer videoPlayerReply;
    [SerializeField] private GameObject videoGameObjectReply;

    [SerializeField] private VideoPlayer videoPlayerReject;
    [SerializeField] private GameObject videoGameObjectReject;

    public bool reply = false;
    public bool reject = false;
    public bool choice = false;

    public UnityEvent ChooseReplyReject;
    public void PlayChoice()
    {
        choice = true;
        videoGameObject.SetActive(true); // Enable the video GameObject when the player enters the trigger area
        videoPlayer.Play(); // Start playing the video
    }
    public void PlayReply()
    {
        reply = true;            

        videoGameObject.SetActive(false); // Enable the video GameObject when the player enters the trigger area
        videoPlayer.Stop(); // Start playing the video
        videoGameObjectReply.SetActive(true); // Enable the video GameObject when the player enters the trigger area
        videoPlayerReply.Play(); // Start playing the video
    }
    public void PlayReject()
    {
        reject = true;
        videoGameObject.SetActive(false); // Enable the video GameObject when the player enters the trigger area
        videoPlayer.Stop(); // Start playing the video
        videoGameObjectReject.SetActive(true); // Enable the video GameObject when the player enters the trigger area
        videoPlayerReject.Play(); // Start playing the video
    }

    public void STOPPLAYING()
    {
            videoGameObject.SetActive(false); // Enable the video GameObject when the player enters the trigger area
            videoPlayer.Stop();
            videoGameObjectReply.SetActive(false); // Enable the video GameObject when the player enters the trigger area
            videoPlayerReply.Stop();
            videoGameObjectReject.SetActive(false); // Enable the video GameObject when the player enters the trigger area
            videoPlayerReject.Stop();
    }
   



}