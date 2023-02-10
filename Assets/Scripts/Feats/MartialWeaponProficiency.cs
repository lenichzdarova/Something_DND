
using System.Collections.Generic;

public class MartialWeaponProficiency: Feat, IWeaponProficiencyProvider
{
    public List<WeaponEnum> GetWeaponTypes()
    {
        return new List<WeaponEnum>()
        {//melee
            WeaponEnum.Battleaxe,
            WeaponEnum.Flail,
            WeaponEnum.Glaive,
            WeaponEnum.Greataxe,
            WeaponEnum.Greatsword,
            WeaponEnum.Halberd,
            WeaponEnum.Lance,
            WeaponEnum.Longsword,
            WeaponEnum.Maul,
            WeaponEnum.Morningstar,
            WeaponEnum.Pike,
            WeaponEnum.Rapier,
            WeaponEnum.Scimitar,
            WeaponEnum.Shortsword,
            WeaponEnum.Trident,
            WeaponEnum.War_pick,
            WeaponEnum.Warhammer,
            WeaponEnum.Whip,
            //ranged
            WeaponEnum.Blowgun,
            WeaponEnum.Crossbow_hand,
            WeaponEnum.Crossbow_heavy,
            WeaponEnum.Longbow,
            WeaponEnum.Net
        };
    }
}
