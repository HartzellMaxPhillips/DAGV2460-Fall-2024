using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;       // Reference to the slider
    public FloatData healthData;    // Reference to the HealthData ScriptableObject

    // Call this method whenever health changes
    public void UpdateHealthBar()
    {
        // Set the slider's value to match the current health value
        healthSlider.maxValue = healthData.maxValue;
        healthSlider.value = healthData.Value;
    }
}
