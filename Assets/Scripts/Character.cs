
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Profiling;

/// <summary>
///Chracter class problems
/// Lots of repeating calculations. almost all character stats need to calculate abilities etc.
/// This should not affect perfomance but looks shitty.
/// </summary>

public class Character : IInventoryProvider, IAttackProvider, IDamageProvider, ISavingThrowsProvider, IAbilitiesProvider
{
    private RaceEnum _characterRace;
    private ClassEnum _characterClass;
    private Abilities _abilities;
    public Sprite Portrait { get; private set; }    

    public LevelProgress _levelProgress;
    private readonly Health _health;

    private FeatsHandler _featsHandler;
    private AbilitiesHandler _abilitiesHandler;

    
    
    public Character(RaceEnum race, ClassEnum characterClass, Abilities abilities) //first lvl character constructor
    {
        _characterRace = race;
        _characterClass = characterClass;        
        Portrait = default;
        _featsHandler = new FeatsHandler(race, characterClass);
        _abilitiesHandler = new AbilitiesHandler(abilities, _featsHandler);
        _health = new Health(characterClass,abilities);                
    }

    public Abilities GetAbilities()
    {
        return _abilitiesHandler.GetAbilities();
    }    

    public int GetAttack()
    {
        int attackBonus = 0;
        attackBonus += BaseAttackBonusProvider.GetAttackBonus(_characterClass, 
            _levelProgress.CurrentLevel);
        attackBonus += AbilitiesAttackBonusProvider.GetAttackBonus(GetAbilities());
        var feats = _featsHandler.GetAttackFeats();
        foreach (var feat in feats)
        {
            attackBonus += feat.GetAttack();
        }               
        return attackBonus;
    }

    public int GetArmor()
    {
        int result = 0;
        //armor
        //

        return result;
    }

    public SavingThrows GetSavingThrows()
    {
        SavingThrows result = new SavingThrows();
        var feats = _featsHandler.GetSavingThrowFeats();
        foreach (var feat in feats)
        {
            result += feat.GetSavingThrows();
        }
        return result;
    }    
}
