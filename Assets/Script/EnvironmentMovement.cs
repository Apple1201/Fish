using UnityEngine;

public class EnvironmentMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Speed of movement
    [SerializeField] private float leftBound = -10f; // Left boundary position
    [SerializeField] private float rightBound = 10f; // Right boundary position

    private Transform parentTransform;

    void Start()
    {
        // Get the parent transform of all the objects
        parentTransform = transform;
    }

    void Update()
    {
        // Move the parent object (containing all objects) from right to left continuously
        parentTransform.Translate(Vector3.left * speed * Time.deltaTime);

        // Check if the parent object reaches the left boundary and reset its position to the right boundary
        if (parentTransform.position.x <= leftBound)
        {
            parentTransform.position = new Vector3(rightBound, parentTransform.position.y, parentTransform.position.z);
        }
    }
}