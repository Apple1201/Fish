using UnityEngine;
using UnityEngine.UI;

public class ImageTrigger : MonoBehaviour
{
    [SerializeField] private Image imageToShow;

    private bool playerInsideTrigger = false;

    void Start()
    {
        // Hide the image initially
        imageToShow.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInsideTrigger = true;
            imageToShow.gameObject.SetActive(true); // Show the image when the player enters the trigger area
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInsideTrigger = false;
            imageToShow.gameObject.SetActive(false); // Hide the image when the player exits the trigger area
        }
    }
}