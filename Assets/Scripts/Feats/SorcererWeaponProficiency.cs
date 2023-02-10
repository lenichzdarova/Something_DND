using System.Collections.Generic;

public class SorcererWeaponProficiency : Feat, IWeaponProficiencyProvider
{   

    public List<WeaponEnum> GetWeaponTypes()
    {
        List<WeaponEnum> weapons = new()
        {
            WeaponEnum.Dagger,
            WeaponEnum.Dart,
            WeaponEnum.Sling,
            WeaponEnum.Quarterstaff,
            WeaponEnum.Crossbow_light
        };
        return weapons;
    }
}
