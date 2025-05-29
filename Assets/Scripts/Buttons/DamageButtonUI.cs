using UnityEngine;

[RequireComponent(typeof(HealthActionButtonUI))]

public class DamageButtonUI : HealthActionButtonUI
{
    protected override void PerformAction(float amount)
    {
        Health.TakeDamage(amount);
    }
}