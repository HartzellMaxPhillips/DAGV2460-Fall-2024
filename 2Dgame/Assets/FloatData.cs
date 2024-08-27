//Transparency: This is copied from the video in the module piece by piece.
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float num)
    {
        value += num;
    }
}