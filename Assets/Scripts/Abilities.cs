using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Abilities 
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }    
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

    public static Abilities operator +(Abilities a, Abilities b)
    {
        return new Abilities
        {
            Strength = a.Strength + b.Strength,
            Dexterity = a.Dexterity + b.Dexterity,
            Constitution = a.Constitution + b.Constitution,
            Intelligence = a.Intelligence + b.Intelligence,
            Wisdom = a.Wisdom + b.Wisdom,
            Charisma = a.Charisma + b.Charisma
        };
    }

    public int GetStrengthBonus()
    {
        return AbilityBonusCalculation(Strength);
    }
    public int GetDexterityBonus()
    {
        return AbilityBonusCalculation(Dexterity);
    }
    public int GetConstitutionBonus()
    {
        return AbilityBonusCalculation(Constitution);
    }
    public int GetIntelligenceBonus()
    {
        return AbilityBonusCalculation(Intelligence);
    }
    public int GetWisdomBonus()
    {
        return AbilityBonusCalculation(Wisdom);
    }
    public int GetCharismaBonus()
    {
        return AbilityBonusCalculation(Charisma);
    }


    private int AbilityBonusCalculation(int abilityValue)
    {
        return (abilityValue - 10) / 2;
    }

}
