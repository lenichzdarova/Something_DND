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
    private readonly RaceType _characterRace;
    private readonly ClassType _characterClass;
    private readonly CharacterStats _stats;
    private readonly Sprite _portrait;

    private readonly Health _health;   

    public Sprite GetPortrait()
    {
        return _portrait;
    }    
}
