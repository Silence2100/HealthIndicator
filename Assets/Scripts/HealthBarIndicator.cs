using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class HealthBarIndicator : HealthBarBaseIndicator
{
    protected override void OnHealthChanged(float normalizedValue)
    {
        _slider.value = normalizedValue;
    }
}