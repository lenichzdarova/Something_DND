using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private RaceType _characterRace;
    private ClassType _characterClass;
    private CharacterStats _stats;

    private Health _health;

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
}
