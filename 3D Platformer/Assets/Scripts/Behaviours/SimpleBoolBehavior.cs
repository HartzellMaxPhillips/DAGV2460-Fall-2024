using UnityEngine;
using UnityEngine.Events;

public class SimpleBoolBehavior : MonoBehaviour
{
    public UnityEvent trueEvent, falseEvent;
    public SimpleBoolData boolData;

    public void CheckBool()
    {
        if (boolData.value)
        {
            trueEvent.Invoke();
        }
        else
        {
            falseEvent.Invoke();
        }
    }
}


