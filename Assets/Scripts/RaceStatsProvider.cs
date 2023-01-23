

using System;

public class RaceStatsProvider
{
    private CharacterStats GetStats(RaceType race)
    {
        switch (race)
        {
            default:
                {
                    throw new NotImplementedException( $"Race type {race} not implemented yet");
                }                
        }        
    }
}


