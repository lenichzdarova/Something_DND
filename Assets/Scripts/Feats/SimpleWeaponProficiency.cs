
using System;
using System.Collections.Generic;


public class SimpleWeaponProficiency : Feat, IWeaponProficiencyProvider
{
    public List<WeaponEnum> GetWeaponTypes()
    {
        return new List<WeaponEnum>()
        {
            //simple melee
            WeaponEnum.Club,
            WeaponEnum.Dagger,
            WeaponEnum.Greatclub,
            WeaponEnum.Handaxe,
            WeaponEnum.Javelin,
            WeaponEnum.Light_hammer,
            WeaponEnum.Mace,
            WeaponEnum.Quarterstaff,
            WeaponEnum.Sickle,
            WeaponEnum.Spear,
            WeaponEnum.Unurmed_strike,
            //simple ranged
            WeaponEnum.Crossbow_light,
            WeaponEnum.Dart,
            WeaponEnum.Shortbox,
            WeaponEnum.Sling
        };
    }
}
