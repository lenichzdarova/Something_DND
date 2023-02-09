
using UnityEngine;

public static class DiceRoller
{
    private const int MIN_DICE_FACES = 1;
    public static int Roll((int,int) rollsFaces)
    {
        int result = 0;
        
        for(int i =0;i<rollsFaces.Item1;i++)
        {
            result += Random.Range(MIN_DICE_FACES, rollsFaces.Item2 +1);
        }
        return result;
    }
}
