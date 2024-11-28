using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Single Variables/FloatData")]
public class FloatData : NameId
{
    [SerializeField] public float value,  minValue, maxValue;

    [FormerlySerializedAs("minValueEvent")] public UnityEvent<float> valueOutOfRange;
    [FormerlySerializedAs("updateValueEvent")] public UnityEvent onValueChanged;

    public float Value
    {
        get => value;
        set
        {
            this.value = value;
            onValueChanged.Invoke();
            CheckValueRange();
        }
    }

    public void UpdateValue(float amount)
    {
        Value += amount;
    }
    
    public void UpdateMaxValue(float amount)
    {
        maxValue += amount;
    }
    
    public void SetMaxValue(float amount)
    {
        maxValue = amount;
    }
    
    public void SetValue(float amount)
    {
        Value = amount;
    }

    public void UpdateValue(FloatData data)
    {
        Value += data.Value;
    }

    public void SetValue(FloatData data)
    {
        Value = data.Value;
    }
    
    public void UpdateValueToMax(FloatData data)
    {
        Value = data.maxValue;
    }
    private void CheckValueRange()
    {
        if (!(Value < minValue) && !(Value > maxValue)) return;
        valueOutOfRange.Invoke(Value);
        Value = Mathf.Clamp(Value, minValue, maxValue);
    }
}