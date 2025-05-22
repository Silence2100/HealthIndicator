using UnityEngine;
using UnityEngine.UI;

public class HealthBarIndicator : MonoBehaviour
{
    [SerializeField] private Health _health;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();

        _slider.minValue = 0f;
        _slider.maxValue = 1f;
    }

    private void Update()
    {
        if (_health.MaxHealth <= 0f)
        {
            _slider.value = 0f;
            return;
        }

        float normalized = _health.CurrentHealth / _health.MaxHealth;
        _slider.value = Mathf.Clamp01(normalized);
    }
}