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

    public List<WeaponType> GetWeaponTypes()
    {
        List<WeaponType> weapons = new()
        {            
            WeaponType.Shortsword            
        };
        return weapons;
    }
}
