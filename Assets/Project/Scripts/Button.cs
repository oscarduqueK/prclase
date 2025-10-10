using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public UnityEvent OnRichardDeath;
    public UnityEvent OnAlexDeath;

    [SerializeField] private Image richardHealthSlider;
    [SerializeField] private Image alexHealthSlider;
    [field: SerializeField] public int MaxHealth { get; private set; } = 100;

    int richardHealth = 100;
    int alexHealth = 100;

    public void Start()
    {
        richardHealth = MaxHealth;
        alexHealth = MaxHealth;
    }

    public void DamageRichard(int amount)
    {
        richardHealth = Mathf.Max(0, richardHealth - amount);
        richardHealthSlider.fillAmount = (float)richardHealth / (float)MaxHealth;
        if (richardHealth == 0)
        {
            OnRichardDeath.Invoke();
        }
    }
    public void DamageAlex(int amount)
    {
        alexHealth = Mathf.Max(0, alexHealth - amount);
        alexHealthSlider.fillAmount = (float)alexHealth / (float)MaxHealth;
        if (alexHealth == 0)
        {
            OnAlexDeath.Invoke();
        }
    }

}
