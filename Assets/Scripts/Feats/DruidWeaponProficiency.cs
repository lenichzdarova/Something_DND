using System.Collections.Generic;

public class DruidWeaponProficiency : CharacterFeat, IWeaponProficiencyProvider
{
    public List<WeaponType> GetWeaponTypes()
    {
        List<WeaponType> weapons = new()
        {
            WeaponType.Club,
            WeaponType.Dagger,
            WeaponType.Dart,
            WeaponType.Javelin,
            WeaponType.Mace,
            WeaponType.Quarterstaff,
            WeaponType.Scimitar,
            WeaponType.Sickle,
            WeaponType.Sling,
            WeaponType.Spear

        };
        return weapons;
    }
}
