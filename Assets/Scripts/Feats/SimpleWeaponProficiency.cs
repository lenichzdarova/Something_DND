
using System;
using System.Collections.Generic;


public class SimpleWeaponProficiency : CharacterFeat, IWeaponProficiencyProvider
{
    public List<WeaponType> GetWeaponTypes()
    {
        return new List<WeaponType>()
        {
            //simple melee
            WeaponType.Club,
            WeaponType.Dagger,
            WeaponType.Greatclub,
            WeaponType.Handaxe,
            WeaponType.Javelin,
            WeaponType.Light_hammer,
            WeaponType.Mace,
            WeaponType.Quarterstaff,
            WeaponType.Sickle,
            WeaponType.Spear,
            WeaponType.Unurmed_strike,
            //simple ranged
            WeaponType.Crossbow_light,
            WeaponType.Dart,
            WeaponType.Shortbox,
            WeaponType.Sling
        };
    }
}
