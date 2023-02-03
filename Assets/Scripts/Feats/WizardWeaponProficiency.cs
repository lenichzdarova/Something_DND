using System.Collections.Generic;


public class WizardWeaponProficiency : CharacterFeat, IWeaponProficiencyProvider
{

    public List<WeaponType> GetWeaponTypes()
    {
        List<WeaponType> weapons = new()
        {
            WeaponType.Dagger,
            WeaponType.Dart,
            WeaponType.Sling,
            WeaponType.Quarterstaff,
            WeaponType.Crossbow_light
        };
        return weapons;
    }
}
