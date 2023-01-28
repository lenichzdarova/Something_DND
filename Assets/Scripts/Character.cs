using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : IInventoryDataProvider
{
    private readonly RaceType _characterRace;
    private readonly ClassType _characterClass;
    private readonly CharacterStats _stats;
    private readonly Sprite _portrait;

    private readonly Health _health;

    public int GetAttack()
    {
        int characterLevel=0; //gag
        int attackBonus = 0;
        attackBonus += BaseAttackBonusProvider.GetAttackBonus(_characterClass, characterLevel);
        //plus Getstats() stats bonus
        //plus items bonus
        //plus effects bonus
        //return summary

        return attackBonus;
    }

    public CharacterStats GetStats()
    {
        var stats = new CharacterStats();
        //_stats
        //plus item bonus
        //plus effects
        //return summary
        return stats;
    }

    public Sprite GetPortrait()
    {
        return _portrait;
    }    
}
