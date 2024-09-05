using UnityEngine;
using UnityEngine.Events;
//I used GPT to help put this together.
public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent awakeEvent, startEvent, disableEvent, 
        triggerEnterEvent, destroyEvent, mouseDragEvent;  // Separate events for Awake, Start, and Disable// UnityEvents for trigger enter and destruction
    public bool destroyOnTrigger;  // Option to destroy this GameObject on trigger enter

    private void Awake()
    {
        awakeEvent.Invoke();  // Invoke custom events for Awake
    }

    private void Start()
    {
        startEvent.Invoke();  // Invoke custom events for Start
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();  // Invoke custom events on trigger enter

        // Destroy this GameObject if destroyOnTrigger is enabled
        if (destroyOnTrigger)
        {
            Destroy(gameObject);
            destroyEvent.Invoke();  // Invoke custom events on destroy
        }
    }

    private void OnDisable()
    {
        disableEvent.Invoke();  // Invoke custom events on disable
    }

    private void OnDestroy()
    {
        destroyEvent.Invoke();  // Invoke custom events on destroy
    }

    private void OnMouseDrag()
    {
        mouseDragEvent.Invoke();
    }
}