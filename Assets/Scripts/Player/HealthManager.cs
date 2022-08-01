using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float currentHealth;
    
    private void Awake()
    {
        currentHealth = maxHealth;
    }
    public void Hit(float damage)
    {
        currentHealth -= damage;
        if(currentHealth < 0)
        {
            Time.timeScale = 0;
        }
    }
}
