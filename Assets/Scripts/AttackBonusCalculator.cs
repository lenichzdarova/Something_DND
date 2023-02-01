


public class AttackBonusCalculator
{
    public static int GetAttackBonus(Character character)
    {
        int attackBonus = 0;
        attackBonus += BaseAttackBonusProvider.GetAttackBonus(character._characterClass,character.Level);       
        attackBonus += GetStatsAttackBonus(character); //bad moment need rework
        //here we check for IAttackEffect and apply it
        //dice roll here
        return attackBonus;
    }

    private static int GetStatsAttackBonus(Character character)
    {
        var stats = StatsCalculator.GetStats(character);
        //here we must know on what stat weapon attack based. str or dex;
        int attackBonus = stats.Strength / 2; 
        return attackBonus;
    }
}
