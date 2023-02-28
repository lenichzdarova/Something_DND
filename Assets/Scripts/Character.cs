
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///Chracter class problems
/// Lots of repeating calculations. almost all character stats need to calculate abilities etc.
/// This should not affect perfomance but looks shitty.
/// </summary>

public class Character 
{
    private RaceEnum _characterRace;
    private ClassEnum _characterClass;    
    public Sprite Portrait { get; private set; }    

    public LevelProgress _levelProgress;
    private readonly Health _health;

    private AbilitiesHandler _abilitiesHandler;
    private ArmorHandler _armorHandler;
    private AttackHandler _attackHandler;
    private FeatsHandler _featsHandler;      
    private SavingThrowsHandler _savingThrowsHandler;    
    
    public Character(RaceEnum race, ClassEnum characterClass, Abilities abilities) //first lvl character constructor
    {
        _characterRace = race;
        _characterClass = characterClass;        
        Portrait = default;
        _featsHandler = new FeatsHandler();
        _featsHandler.AddFeat(RaceFeatsProvider.GetFeats(race));
        _featsHandler.AddFeat(ClassFeatsProvider.GetFeats(characterClass, _levelProgress.CurrentLevel));        
        _abilitiesHandler = new AbilitiesHandler( _featsHandler);
        _abilitiesHandler.AddAbilities(abilities);
        _health = new Health(characterClass,abilities);                
    }

    public Abilities GetAbilities()
    {
        return _abilitiesHandler.GetAbilities();
    }  
    
    public List<Feat> GetFeats()
    {
        return _featsHandler.Feats;
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
        return _armorHandler.GetArmor();
    }

    public SavingThrows GetSavingThrows()
    {       
        return _savingThrowsHandler.GetSavingThrows();
    }    
}
