using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class RestartGameOnVideoEnd : MonoBehaviour
{
    public VideoPlayer goodEndVideo;
    public VideoPlayer badEndVideo;

    void Start()
    {
        goodEndVideo.loopPointReached += OnGoodEndVideoEnd;
        badEndVideo.loopPointReached += OnBadEndVideoEnd;
    }

    void OnGoodEndVideoEnd(VideoPlayer vp)
    {
        RestartGame();
    }

    void OnBadEndVideoEnd(VideoPlayer vp)
    {
        RestartGame();
    }

    void RestartGame()
    {
        // Reload the current scene to restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}