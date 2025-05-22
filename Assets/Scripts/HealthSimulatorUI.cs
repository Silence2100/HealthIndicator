using UnityEngine;

public class HealthSimulatorUI : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private float _damageAmount = 10f;
    [SerializeField] private float _healAmount = 10f;

    public void ApplyDamage()
    {
        _health.TakeDamage(_damageAmount);
    }

    public void AppleHeal()
    {
        _health.Heal(_healAmount);
    }
}