
using System.Collections.Generic;

public class FighterWeaponProficiency: CharacterFeat, IWeaponProficiencyProvider
{
    public List<WeaponType> GetWeaponTypes()
    {
        IWeaponProficiencyProvider simple = new SimpleWeaponProficiency();
        IWeaponProficiencyProvider martial= new MartialWeaponProficiency();
        List<WeaponType> simpleWeapons = simple.GetWeaponTypes();
        List<WeaponType> martialWeapons = martial.GetWeaponTypes();
        simpleWeapons.AddRange(martialWeapons);
        return simpleWeapons;
    }
}
