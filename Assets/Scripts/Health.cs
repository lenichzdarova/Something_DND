using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health 
{
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
}
