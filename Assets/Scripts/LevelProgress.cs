using UnityEngine;

public class LevelProgress 
{
    private int _level;
    private int _experience;

    public void AddExperience(int value)
    {
        _experience += value;
        if(_experience > ExperienceTableProvider.ExperienceToNextLevel(_level))
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {

    }
}