using UnityEngine;

public class DestroyOutOfMap : MonoBehaviour
{
    [SerializeField] private float minX;
    [SerializeField] private float minY;
    [SerializeField] private float minZ;
    [SerializeField] private float maxX;
    [SerializeField] private float maxY;
    [SerializeField] private float maxZ;

    void Update()
    {
        CheckOutOfBounds();
    }

    void CheckOutOfBounds()
    {
        Vector3 objectPosition = transform.position;

        // Check if the object is outside the defined bounds
        if (objectPosition.x < minX || objectPosition.x > maxX ||
            objectPosition.y < minY || objectPosition.y > maxY ||
            objectPosition.z < minZ || objectPosition.z > maxZ)
        {
            Destroy(gameObject); // Destroy the object if it's out of bounds
        }
    }
}
