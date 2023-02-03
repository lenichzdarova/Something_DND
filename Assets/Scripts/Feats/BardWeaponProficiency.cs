using System.Collections.Generic;

public class BardWeaponProficiency : CharacterFeat, ICharacterFeatsProvider, IWeaponProficiencyProvider
{
    public List<CharacterFeat> GetCharacterFeats()
    {
        List<CharacterFeat> feats = new()
        {
            new SimpleWeaponProficiency()
        };

        return feats;
    }

    public List<WeaponType> GetWeaponTypes()
    {
        List<WeaponType> weapons = new()
        {
            WeaponType.Longsword,
            WeaponType.Shortsword,
            WeaponType.Rapier,
            WeaponType.Crossbow_hand
        };
        return weapons;
    }
}
