


static class AttackBonusCalculator
{
    public static int GetAttackBonus(Character character)
    {
        int attackBonus = 0;
        attackBonus += BaseAttackBonusProvider.GetAttackBonus(character._characterClass,character.Level);
        attackBonus += AbilitiesAttackBonusProvider.GetAttackBonus(character);
        //here we check for IAttackProvider effects and apply it        
        return attackBonus;
    }    
}
