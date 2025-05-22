using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthTextIndicator : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private TMP_Text _tmpText;

    private void Awake()
    {
        _tmpText = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        string formattedHealth = $"{_health.CurrentHealth}/{_health.MaxHealth}";

        if (_tmpText != null)
            _tmpText.text = formattedHealth;
    }
}