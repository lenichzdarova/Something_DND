

static class BaseAttackBonusProvider
{
    private const float HIGH_PROGRESSION = 1f;
    private const float MEDIUM_PROGRESSION = 0.75f;
    private const float LOW_PROGRESSION = 0.5f;


    public static int GetAttackBonus(CharacterClass characterClass, int characterLevel)
    {
        int baseAttackBonus = 0;
        if(characterClass == CharacterClass.Fighter)
        {
            baseAttackBonus = (int)(HIGH_PROGRESSION * characterLevel);
        }
        if(characterClass == CharacterClass.Rogue)
        {
            baseAttackBonus = (int)(MEDIUM_PROGRESSION * characterLevel);
        }
        if(characterClass == CharacterClass.Wizard)
        {
            baseAttackBonus = (int)(LOW_PROGRESSION * characterLevel);
        }
        return baseAttackBonus;
    }   
}
