using UnityEngine;
//Used ChatGPT to help me make this.
public class CubeMovement : MonoBehaviour
{
    public Vector3Data movementData;  // Reference to the ScriptableObject
    public float speed = 0.1f;          // Movement speed

    private void Update()
    {
        // Move the object using the value from the Vector3Data ScriptableObject
        transform.Translate(movementData.value * (speed * Time.deltaTime));
    }
}

