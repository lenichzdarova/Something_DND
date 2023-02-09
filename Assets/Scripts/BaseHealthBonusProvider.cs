
using System;
using UnityEngine;

public class BaseHealthBonusProvider 
{
    public static (int,int) GetHealth(ClassEnum characterClass)
    {
        return characterClass switch
        {
            ClassEnum.Fighter => (1,12),
            ClassEnum.Rogue => (1, 4),
            ClassEnum.Wizard => (1, 6),
            _ => throw new NotImplementedException($"Character class {characterClass} health bonus not implemented")
        };
    }
}