using System.Collections.Generic;

public class DruidWeaponProficiency : Feat, IWeaponProficiencyProvider
{
    public List<WeaponEnum> GetWeaponTypes()
    {
        List<WeaponEnum> weapons = new()
        {
            WeaponEnum.Club,
            WeaponEnum.Dagger,
            WeaponEnum.Dart,
            WeaponEnum.Javelin,
            WeaponEnum.Mace,
            WeaponEnum.Quarterstaff,
            WeaponEnum.Scimitar,
            WeaponEnum.Sickle,
            WeaponEnum.Sling,
            WeaponEnum.Spear

        };
        return weapons;
    }
}
