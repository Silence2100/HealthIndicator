using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]

public class HealthTextIndicator : MonoBehaviour
{
    [SerializeField] private Health _health;
    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();

        _health.OnHealthChanged += UpdateText;
    }

    private void OnDestroy()
    {
        if (_health != null)
        {
            _health.OnHealthChanged -= UpdateText;
        }
    }

    private void UpdateText(float current, float max)
    {
        _text.text = $"{current}/{max}";
    }
}