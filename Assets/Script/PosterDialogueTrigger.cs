using UnityEngine;

public class PosterDialogueTrigger : MonoBehaviour
{
    [SerializeField] private TextAsset dialogueTextFile;
    private bool playerInRange = false;
    private bool dialogueTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogueTriggered = false; // Reset dialogue trigger when player exits
        }
    }

    private void Update()
    {
        if (playerInRange && !dialogueTriggered)
        {
            // You can replace the Debug.Log with your dialogue display code
            Debug.Log("Display Dialogue: " + dialogueTextFile.text);
            dialogueTriggered = true;
        }
    }
}