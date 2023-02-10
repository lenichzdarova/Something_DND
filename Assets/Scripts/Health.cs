using System;
/// <summary>
/// TODO
/// additional parametr - IhealthProvider which incapsulate all hp bonuses from featû and other effects
/// RemoveHealth() method - negative health value constitution bonus check. unconscious or dead
/// </summary>

public class Health 
{    

    private int _maxHealth;
    private int _baseHealth; //persistent, rolled value
    private int _currentHealth;

    public int CurrentHealth { get => _currentHealth; }
    public int MaxHealth { get => _maxHealth; }


    public Health(ClassEnum characterClass, Abilities abilities) //first level character constructor
    {
        int defaultCharacterLevel = 1;
        _baseHealth = BaseHealthRoll(characterClass, defaultCharacterLevel);        
        MaxHealthCalculation(abilities.GetConstitutionBonus(), defaultCharacterLevel);
        _currentHealth = _maxHealth;
    }

    public Health(int baseHealth,int currentHealth, int maxHealth) // loading constructor
    {
        _baseHealth = baseHealth;
        _currentHealth = currentHealth;
        _maxHealth = maxHealth;
    }

    public void OnLevelUp(ClassEnum characterClass, int currentLevel, Abilities abilities)
    {
        int healthBonus = BaseHealthRoll(characterClass,currentLevel);
        _baseHealth += healthBonus;
        _currentHealth += healthBonus;
        MaxHealthCalculation(abilities.GetConstitutionBonus(),currentLevel);             
    }

    private int BaseHealthRoll(ClassEnum characterClass, int currentLevel)
    {
        Dices roll = BaseHealthBonusProvider.GetHealth(characterClass);
        int rollResult = currentLevel<=3 ? roll.MaxRoll() : roll.Roll();
        return rollResult;
    }
    
    private void MaxHealthCalculation(int constitutionBonus, int characterLevel)
    {
        _maxHealth = (_baseHealth + constitutionBonus * characterLevel);
    }

    public void AddHealth(int value)
    {
        _currentHealth -= value;
        if(_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }
    public void RemoveHealth(int value)
    {
        _currentHealth -= value;
        if(_currentHealth <= 0) 
        {
            //check endurance bonus for unconscious or death
        }
    }    
}
