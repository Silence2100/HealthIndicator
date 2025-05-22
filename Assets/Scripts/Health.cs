using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100f;

    public float MaxHealth => _maxHealth;
    public float CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    public void TakeDamage(float amount)
    {
        if (amount <= 0f) return;

        CurrentHealth = Mathf.Clamp(CurrentHealth - amount, 0f, _maxHealth);
    }

    public void Heal(float amount)
    {
        if (amount <= 0f) return;

        CurrentHealth = Mathf.Clamp(CurrentHealth + amount, 0f, _maxHealth);
    }
}