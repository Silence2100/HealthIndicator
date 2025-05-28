using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class HealthSmoothBarIndicator : HealthBarBaseIndicator
{
    [SerializeField] private float _smoothSpeed = 1f;
    private float _displayedValue;

    protected override void Start()
    {
        base.Start();
        _displayedValue = _targetValue;
        _slider.value = _displayedValue;
    }

    protected override void OnHealthChanged(float normalizedValue)
    {
        _targetValue = normalizedValue;
    }

    private void Update()
    {
        if (_displayedValue != _targetValue)
        {
            _displayedValue = Mathf.MoveTowards(_displayedValue, _targetValue, _smoothSpeed * Time.deltaTime);
            _slider.value = _displayedValue;
        }
    }
}