using System.Collections.Generic;

public class MonkWeaponProficiency : Feat, ICharacterFeatsProvider, IWeaponProficiencyProvider
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
            WeaponEnum.Shortsword            
        };
        return weapons;
    }
}
