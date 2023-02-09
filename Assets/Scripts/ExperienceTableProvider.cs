
using System;
using UnityEngine;

public class ExperienceTableProvider
{
    public static int ExperienceToNextLevel(int currentLevel) 
    {
        return currentLevel switch
        {
            0 => 0,
            1 => 1,
            2 => 2,
            3 => 3,
            4 => 4,
            5 => 5,
            6 => 6,
            7 => 7,
            8 => 8,
            9 => 9,
            10 => 10,
            11 => 11,
            12 => 12,
            13 => 13,
            14 => 14,
            15 => 15,
            17 => 0,
            18 => 18,
            19 => 19,
            20 => 20,
            _ => throw new NotImplementedException($"Experience table for level {currentLevel} not implemented")
        };
    }
}