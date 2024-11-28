using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;       // Reference to the slider
    public FloatData healthData;      // Reference to the HealthData ScriptableObject
    public UnityEvent OnDeath;        // UnityEvent for death event
    public UnityEvent Respawn;        // UnityEvent for respawn event

    // Call this method whenever health changes
    public void UpdateHealthBar()
    {
        // Set the slider's value to match the current health value
        healthSlider.maxValue = healthData.maxValue;
        healthSlider.value = healthData.Value;

        // If the health value is less than or equal to 0, call the Die method
        if (healthData.Value <= 0)
        {
            OnDeath.Invoke();
            StartCoroutine(RespawnCoroutine());
        }
    }

    private IEnumerator RespawnCoroutine()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3f);
        // Invoke the Respawn event
        Respawn.Invoke();
    }
}