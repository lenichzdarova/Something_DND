using UnityEngine;

/// <summary>
/// Character is a container of basic character data;
/// No attack, no damage, no armor or some shit like this.
/// All characters composite statistic must be provide by servises.
/// How it works - attackProviderServise,as axample:
/// its is static class.
/// he call baseattackbonusprovider - get class and level and return base attackbonus
/// call stats provider - he calculate character stats and return bonus of strength
/// call effectshandler nad get bonuses from it
/// return sum
/// 
/// about effectsHandler
/// how effects system work.
/// effect - possybly abstract class;
/// character equip +1 sword and add weaponbonusplusone to effects collection.
/// This effect inherit from two interfaces - IattackEffect and IdamageEffect
/// AttackProviderServise, as example, search iattackeffect in callection and use it.
/// 
/// </summary>

public class Character : IInventoryDataProvider
{
    public readonly Race _characterRace;
    public readonly CharacterClass _characterClass;
    public readonly Abilities _abilities;
    public readonly Sprite _portrait;

    public int Level { get; private set; }

    private readonly Health _health;  
    
    public Character(Race race, CharacterClass characterClass, Abilities abilities)
    {
        _characterRace = race;
        _characterClass = characterClass;
        _abilities = abilities;
        _portrait = default(Sprite);
        _health = new Health();
    }
}
