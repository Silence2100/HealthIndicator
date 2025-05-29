using UnityEngine;

[RequireComponent(typeof(HealthActionButtonUI))]

public class RestoreButtonUI : HealthActionButtonUI
{
    protected override void PerformAction(float amount)
    {
        Health.Restore(amount);
    }
}