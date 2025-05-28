using UnityEngine;
using UnityEngine.UI;

public class HealthSimulatorUI : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Button _damageButton;
    [SerializeField] private Button _restoreButton;
    [SerializeField] private float _damageAmount = 10f;
    [SerializeField] private float _healAmount = 10f;

    private void Awake()
    {
        _damageButton.onClick.AddListener(ApplyDamage);
        _restoreButton.onClick.AddListener(ApplyRestore);
    }

    private void OnDestroy()
    {
        _damageButton.onClick.RemoveListener(ApplyDamage);
        _restoreButton.onClick.RemoveListener(ApplyRestore);
    }

    public void ApplyDamage()
    {
        _health.InflictDamage(_damageAmount);
    }

    public void ApplyRestore()
    {
        _health.Restore(_healAmount);
    }
}