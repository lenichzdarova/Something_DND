using System.Collections.Generic;

public class PristWeaponProficiency : Feat, ICharacterFeatsProvider
{
    public List<Feat> GetCharacterFeats()
    {
        List<Feat> feats = new()
        {
            new SimpleWeaponProficiency()
        };

        return feats;
    }    
}
