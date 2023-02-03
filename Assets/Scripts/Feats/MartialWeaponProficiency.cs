
using System.Collections.Generic;

public class MartialWeaponProficiency: CharacterFeat, IWeaponProficiencyProvider
{
    public List<WeaponType> GetWeaponTypes()
    {
        return new List<WeaponType>()
        {//melee
            WeaponType.Battleaxe,
            WeaponType.Flail,
            WeaponType.Glaive,
            WeaponType.Greataxe,
            WeaponType.Greatsword,
            WeaponType.Halberd,
            WeaponType.Lance,
            WeaponType.Longsword,
            WeaponType.Maul,
            WeaponType.Morningstar,
            WeaponType.Pike,
            WeaponType.Rapier,
            WeaponType.Scimitar,
            WeaponType.Shortsword,
            WeaponType.Trident,
            WeaponType.War_pick,
            WeaponType.Warhammer,
            WeaponType.Whip,
            //ranged
            WeaponType.Blowgun,
            WeaponType.Crossbow_hand,
            WeaponType.Crossbow_heavy,
            WeaponType.Longbow,
            WeaponType.Net
        };
    }
}
