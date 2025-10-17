using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class loevent : MonoBehaviour
{
    public UnityEvent MisterDeath;
    public UnityEvent PacoDeath;
    public UnityEvent winScene;

    [SerializeField] private Image Image;
    [SerializeField] private Image Image2;
    [field: SerializeField] public int MaxHealth { get; private set; } = 100;

    int PacoHealth = 100;
    int MisterHealth = 100;

    public void Start()
    {
        PacoHealth = MaxHealth;
        MisterHealth = MaxHealth;
    }

    public void Update()
    {
        if (MisterHealth <= 0 || PacoHealth <= 0)
        {
            winScene.Invoke();
        }
    }

    public void DamageRichard(int amount)
    {
        PacoHealth = Mathf.Max(0, PacoHealth - amount);
        Image.fillAmount = (float)PacoHealth / (float)MaxHealth;
        if (PacoHealth == 0)
        {
            PacoDeath.Invoke();
        }
    }
    public void DamageAlex(int amount)
    {
        MisterHealth = Mathf.Max(0, MisterHealth - amount);
        Image2.fillAmount = (float)MisterHealth / (float)MaxHealth;
        if (MisterHealth == 0)
        {
            MisterDeath.Invoke();
        }
    }
}
