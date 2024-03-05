using UnityEngine;

public class RespawnOutOfMap : MonoBehaviour
{
    [SerializeField] private float minX;
    [SerializeField] private float minY;
    [SerializeField] private float minZ;
    [SerializeField] private float maxX;
    [SerializeField] private float maxY;
    [SerializeField] private float maxZ;
    [SerializeField] private Vector3 respawnPosition; // The position to respawn the object

    void Update()
    {
        CheckOutOfBounds();
    }

    void CheckOutOfBounds()
    {
        Vector3 objectPosition = transform.position;

        // Check if the object is outside the defined bounds
        if (IsOutOfBounds(objectPosition))
        {
            Invoke("RespawnObject", 0f); // Invoke RespawnObject after 3 seconds
        }
    }

    bool IsOutOfBounds(Vector3 position)
    {
        return (position.x < minX || position.x > maxX ||
                position.y < minY || position.y > maxY ||
                position.z < minZ || position.z > maxZ);
    }

    void RespawnObject()
    {
        gameObject.SetActive(false); // Deactivate the object
        transform.position = respawnPosition; // Move the object to the respawn position
        Invoke("ActivateObject", 0.1f); // Delay the activation slightly to avoid collision issues
    }

    void ActivateObject()
    {
        gameObject.SetActive(true); // Reactivate the object
    }
}
