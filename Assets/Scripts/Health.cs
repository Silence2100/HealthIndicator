using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _max = 100f;

    public float Max => _max;
    public float Current { get; private set; }

    public event Action<float, float> OnHealthChanged;

    private void Start()
    {
        Current = _max;

        OnHealthChanged?.Invoke(Current, Max);
    }

    public void InflictDamage(float amount)
    {
        if (amount < 0f)
        {
            return;
        }

        float old = Current;

        Current = Mathf.Clamp(Current - amount, 0f, _max);

        if (Current != old)
        {
            OnHealthChanged?.Invoke(Current,Max);
        }
    }

    public void Restore(float amount)
    {
        if (amount < 0f)
        {
            return;
        }

        float old = Current;

        Current = Mathf.Clamp(Current + amount, 0f, _max);

        if (Current != old)
        {
            OnHealthChanged?.Invoke(Current, Max);
        }
    }
}