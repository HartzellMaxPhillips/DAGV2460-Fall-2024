using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;  // Event to invoke when trigger occurs
    public UnityEvent onDestroyEvent;     // Event to invoke when the object is destroyed
    public bool destroyOnTrigger = false; // Option to destroy the object after trigger

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();  // Invoke the trigger enter event

        if (destroyOnTrigger)
        {
            Destroy(gameObject);  // Destroy the GameObject if the option is enabled
        }
    }

    private void OnDestroy()
    {
        onDestroyEvent.Invoke();  // Invoke the OnDestroy event when this GameObject is destroyed
    }
}

