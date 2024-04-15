using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public GameObject goodEndObject;
    public GameObject badEndObject;

    private ScoreController scoreController;

    private bool isPlayingGoodEnd = false;
    private bool isPlayingBadEnd = false;

    void Start()
    {
        scoreController = FindObjectOfType<ScoreController>();
    }

    void Update()
    {
        int positivity = scoreController.Positivity;
        int negativity = scoreController.Negativity;

        if (positivity > negativity && !isPlayingGoodEnd)
        {
            isPlayingGoodEnd = true;
            isPlayingBadEnd = false;
            goodEndObject.SetActive(true);
            badEndObject.SetActive(false);
            Debug.Log("GoodEnd object enabled!");
        }
        else if (negativity > positivity && !isPlayingBadEnd)
        {
            isPlayingBadEnd = true;
            isPlayingGoodEnd = false;
            badEndObject.SetActive(true);
            goodEndObject.SetActive(false);
            Debug.Log("BadEnd object enabled!");
        }
    }
}