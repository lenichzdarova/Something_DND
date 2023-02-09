using System.Collections.Generic;

public class RogueWeaponProficiency : CharacterFeat, ICharacterFeatsProvider, IWeaponProficiencyProvider
{
    public List<CharacterFeat> GetCharacterFeats()
    {
        List<CharacterFeat> feats = new()
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
