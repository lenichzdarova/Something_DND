using System;


public class Health 
{
    public event Action<int> HealthChange;
    public event Action<int> MaxHealthChange;

    private int _maxHealth;
    private int _currentHealth;

    public void AddHealth(int health)
    {
        _currentHealth -= health;
        if(_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }
    public void RemoveHealth(int health)
    {
        _currentHealth -= health;
        if(_currentHealth <= 0) 
        {
            //check endurance bonus for unconscious or death
        }
    }

    public int GetHealth()
    {
        return _currentHealth;
    }

    public int GetMaxHealth()
    {
        return _maxHealth;
    }
}
