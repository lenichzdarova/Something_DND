

using System;

static class RaceAbilitiesProvider
{
    public static Abilities GetAbilities(RaceType race)
    {
        switch (race)
        {
            case RaceType.Human:
                {
                    return new Abilities
                    {
                        Strength = 11,
                        Dexterity= 11,
                        Constitution = 11,
                        Intelligence = 11,
                        Wisdom = 11,
                        Charisma = 11                    
                    };
                }
            case RaceType.Half_Ork:
                {
                    return new Abilities
                    {
                        Strength = 12,
                        Dexterity = 10,
                        Constitution = 11,
                        Intelligence = 10,
                        Wisdom = 10,
                        Charisma = 10
                    };
                }
            case RaceType.Elf:
                {
                    return new Abilities
                    {
                        Strength = 10,
                        Dexterity = 12,
                        Constitution = 10,
                        Intelligence = 10,
                        Wisdom = 10,
                        Charisma = 10
                    };
                }
            case RaceType.Dwarf:
                {
                    return new Abilities
                    {
                        Strength = 10,
                        Dexterity = 10,
                        Constitution = 12,
                        Intelligence = 10,
                        Wisdom = 10,
                        Charisma = 10
                    };
                }
            case RaceType.Halfling:
                {
                    return new Abilities
                    {
                        Strength = 10,
                        Dexterity = 12,
                        Constitution = 10,
                        Intelligence = 10,
                        Wisdom = 10,
                        Charisma = 10
                    };
                }
            case RaceType.Gnome:
                {
                    return new Abilities
                    {
                        Strength = 10,
                        Dexterity = 10,
                        Constitution = 10,
                        Intelligence = 12,
                        Wisdom = 10,
                        Charisma = 10
                    };
                }
            default:
                {
                    throw new NotImplementedException( $"Race type {race} not implemented yet");
                }                
        }        
    }
}


