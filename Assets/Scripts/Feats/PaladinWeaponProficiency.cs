using System.Collections.Generic;

public class PaladinWeaponProficiency : CharacterFeat, ICharacterFeatsProvider
{
    public List<CharacterFeat> GetCharacterFeats()
    {
        List<CharacterFeat> feats = new()
        {
            new SimpleWeaponProficiency(),
            new MartialWeaponProficiency()
        };

        return feats;
    }
}
