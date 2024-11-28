using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;       // Reference to the slider
    public FloatData healthData;    // Reference to the HealthData ScriptableObject
    public UnityAction OnDeath;
    
    // Call this method whenever health changes
    public void UpdateHealthBar()
    {
        // Set the slider's value to match the current health value
        healthSlider.maxValue = healthData.maxValue;
        healthSlider.value = healthData.Value;
        
        // If the health value is less than or equal to 0, call the Die method
        if (healthData.Value <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        OnDeath?.Invoke();
    }
}
