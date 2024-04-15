using UnityEngine;

public class EnableObjectOnTrigger : MonoBehaviour
{
    [SerializeField] private GameObject objectToEnable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the triggering object is the player
        {
            objectToEnable.SetActive(true); // Enable the GameObject when the player touches the trigger
        }
    }
}