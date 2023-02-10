
public struct SavingThrows
{
    public int Reflex { get; set; }
    public int Will { get; set; }
    public int Fortitude { get; set; }


    public static SavingThrows operator +(SavingThrows a, SavingThrows b)
    {
        return new SavingThrows
        {
            Reflex = a.Reflex + b.Reflex,
            Will = a.Will + b.Will,
            Fortitude = a.Fortitude + b.Fortitude
        };
    }
}
