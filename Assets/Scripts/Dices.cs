
using UnityEngine;

public struct Dices
{
    private const int MIN_ROLL_RESULT = 1;
    public readonly int rolls;
    public readonly int faces;

    public Dices(int rolls, int faces)
    {
        this.rolls = rolls;
        this.faces = faces;
    }
    public int Roll()
    {
        int result = 0;        
        
        for(int i = 0; i < rolls; i++)
        {
            result += Random.Range(MIN_ROLL_RESULT, faces +1);
        }
        return result;
    }

    public override string ToString()
    {
        return $"{rolls}d{this.faces}";
    }
}
