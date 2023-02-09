
using System;
using UnityEngine;

public class BaseHealthBonusProvider 
{
    public static Dices GetHealth(ClassEnum characterClass)
    {
        return characterClass switch
        {
            ClassEnum.Fighter => new Dices(1,12),
            ClassEnum.Rogue => new Dices(1, 4),
            ClassEnum.Wizard => new Dices(1, 6),
            _ => throw new NotImplementedException($"Character class {characterClass} health bonus not implemented")
        };
    }
}