using System.Collections.Generic;

public class BarbarianWeaponProficiency : Feat, ICharacterFeatsProvider
{
    public List<Feat> GetCharacterFeats()
    {
        List<Feat> feats = new()
        {
            new SimpleWeaponProficiency(),
            new MartialWeaponProficiency()
        };

        return feats;
    }
}
