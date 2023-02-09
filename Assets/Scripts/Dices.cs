
using UnityEngine;

public struct Dices
{
    private const int MIN_ROLL_RESULT = 1;
    private int _rolls;
    private int _faces;

    public Dices(int rolls, int faces)
    {
        this._rolls = rolls;
        this._faces = faces;
    }
    public int Roll()
    {
        int result = 0;        
        
        for(int i = 0; i < _rolls; i++)
        {
            result += Random.Range(MIN_ROLL_RESULT, _faces +1);
        }
        return result;
    }
    public int MaxRoll()
    {
        int result = 0;

        for (int i = 0; i < _rolls; i++)
        {
            result += _faces;
        }
        return result;
    }

    public override string ToString()
    {
        return $"{_rolls}d{this._faces}";
    }
}
