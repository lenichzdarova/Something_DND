
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///Chracter class problems
/// Lots of repeating calculations. almost all character stats need to calculate abilities etc.
/// This should not affect perfomance but looks shitty.
/// </summary>

public class Character : IInventoryProvider, IAttackProvider, IDamageProvider, ISavingThrowsProvider, IAbilitiesProvider, ICharacterFeatsProvider
{
    private RaceEnum _characterRace;
    private ClassEnum _characterClass;
    private Abilities _abilities;
    public Sprite Portrait { get; private set; }    

    public LevelProgress _levelProgress;
    private readonly Health _health;  
    
    public Character(RaceEnum race, ClassEnum characterClass, Abilities abilities)
    {
        _characterRace = race;
        _characterClass = characterClass;
        _abilities = abilities;
        Portrait = default;
        _health = new Health(characterClass,abilities);
    }

    public Abilities GetAbilities()
    {
        Abilities result = _abilities;
        var feats = GetCharacterFeats();
        foreach ( var feat in feats )
        {
            if (feat is IAbilitiesProvider provider)
            {
                result += provider.GetAbilities();
            }
        }
        //sum IabilitiesProvider from effects and feats
        return result;
    }    

    public int GetAttack()
    {
        int attackBonus = 0;
        attackBonus += BaseAttackBonusProvider.GetAttackBonus(_characterClass, 
            _levelProgress.CurrentLevel);
        attackBonus += AbilitiesAttackBonusProvider.GetAttackBonus(GetAbilities());
        var feats = GetCharacterFeats();
        foreach (var feat in feats)
        {
            if (feat is IAttackProvider provider)
            {
                attackBonus += provider.GetAttack();
            }
        }
        //here we check for IAttackProvider effects and apply it        
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
        return result;
    }

    public List<CharacterFeat> GetCharacterFeats()
    {
        List<CharacterFeat> feats = RaceFeatsProvider.GetFeats(_characterRace);
        feats.AddRange(ClassFeatsProvider.GetFeats(_characterClass, _levelProgress.CurrentLevel));
        return feats;
    }
}
