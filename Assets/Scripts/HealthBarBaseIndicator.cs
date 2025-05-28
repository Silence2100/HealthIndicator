using UnityEngine;
using UnityEngine.UI;

public abstract class HealthBarBaseIndicator : MonoBehaviour
{
    [SerializeField] protected Health _health;

    protected Slider _slider;
    protected float _targetValue;

    protected virtual void Start()
    {
        HandleHealthChanged(_health.Current, _health.Max);
    }

    protected virtual void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.minValue = 0f;
        _slider.maxValue = 1f;

        if (_health == null)
        {
            return;
        }

        _health.OnHealthChanged += HandleHealthChanged;
    }

    private void HandleHealthChanged(float current, float max)
    {
        float normalized = (max > 0f) ? current / max : 0f;
        _targetValue = Mathf.Clamp01(normalized);
        OnHealthChanged(_targetValue);
    }

    protected abstract void OnHealthChanged(float normalizedValue);
}