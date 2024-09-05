using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;  // Event that will be invoked on trigger enter
    public bool destroyOnTrigger = false; // Option to destroy the object after trigger

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();  // Invoke the event

        if (destroyOnTrigger)
        {
            Destroy(gameObject);  // Destroy the GameObject if the option is enabled
        }
    }
}

