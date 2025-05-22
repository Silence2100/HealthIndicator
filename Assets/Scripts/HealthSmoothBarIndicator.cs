using UnityEngine;
using UnityEngine.UI;

public class HealthSmoothBarIndicator : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private float _smoothSpeed = 1f;

    private Slider _slider;
    private float _displayedValue;

    private void Start()
    {
        if (_health != null && _health.MaxHealth > 0f)
            _displayedValue = _health.CurrentHealth / _health.MaxHealth;
        else
            _displayedValue = 0f;

        _slider.value = _displayedValue;
    }

    private void Awake()
    {
        _slider = GetComponent<Slider>();

        _slider.minValue = 0f;
        _slider.maxValue = 1f;

        if (_health.MaxHealth > 0f)
            _displayedValue = _health.CurrentHealth / _health.MaxHealth;
        else
            _displayedValue = 0f;

        _slider.value = _displayedValue;
    }

    private void Update()
    {
        if (_health.MaxHealth <= 0f)
            return;

        float targetValue = _health.CurrentHealth / _health.MaxHealth;
        _displayedValue = Mathf.MoveTowards(_displayedValue, targetValue, _smoothSpeed * Time.deltaTime);
        _slider.value = _displayedValue;
    }
}