using System.Collections.Generic;

public class PristWeaponProficiency : CharacterFeat, ICharacterFeatsProvider
{
    public List<CharacterFeat> GetCharacterFeats()
    {
        List<CharacterFeat> feats = new()
        {
            new SimpleWeaponProficiency()
        };

        return feats;
    }    
}
