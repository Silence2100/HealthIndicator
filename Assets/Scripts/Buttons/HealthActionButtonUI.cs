using UnityEngine;
using UnityEngine.UI;

public abstract class HealthActionButtonUI : MonoBehaviour
{
    [SerializeField] protected Health Health;
    [SerializeField] private Button _button;
    [SerializeField] private float _amount = 10f;

    private void Awake()
    {
        _button.onClick.AddListener(OnButtonClicked);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        PerformAction(_amount);
    }

    protected abstract void PerformAction(float amount);
}