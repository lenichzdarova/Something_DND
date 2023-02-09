using System.Collections.Generic;

public class MonkWeaponProficiency : CharacterFeat, ICharacterFeatsProvider, IWeaponProficiencyProvider
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
            WeaponEnum.Shortsword            
        };
        return weapons;
    }
}
