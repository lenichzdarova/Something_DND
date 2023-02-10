using System.Collections.Generic;

public class BardWeaponProficiency : Feat, ICharacterFeatsProvider, IWeaponProficiencyProvider
{
    public List<Feat> GetCharacterFeats()
    {
        List<Feat> feats = new()
        {
            new SimpleWeaponProficiency()
        };

        return feats;
    }

    public List<WeaponEnum> GetWeaponTypes()
    {
        List<WeaponEnum> weapons = new()
        {
            WeaponEnum.Longsword,
            WeaponEnum.Shortsword,
            WeaponEnum.Rapier,
            WeaponEnum.Crossbow_hand
        };
        return weapons;
    }
}
