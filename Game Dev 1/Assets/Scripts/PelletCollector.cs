using UnityEngine;
//ChatGPT fueled script once again.  All part of using the OnDestroy MonoBehavior
//Script uses said behavior to spawn a new pellet.  
public class PelletCollector : MonoBehaviour
{
    public GameObject pelletPrefab;  // Reference to the pellet prefab
    public Transform cubeTransform;  // Reference to the cube's transform
    public float spawnOffset = 1.0f; // How many units to the right to spawn the new pellet

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object colliding is the cube by comparing transforms
        if (other.transform == cubeTransform)
        {
            // Spawn a new pellet 1 or 2 units to the right of the cube
            Vector3 newPelletPosition = cubeTransform.position + new Vector3(spawnOffset, 0, 0);
            Instantiate(pelletPrefab, newPelletPosition, Quaternion.identity);

            // Destroy the current pellet
            Destroy(gameObject);
        }
    }
}
