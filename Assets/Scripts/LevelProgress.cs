using UnityEngine;

public class LevelProgress 
{
    private int _level;
    private int _experience;

    public int CurrentLevel { get => _level; }
    public int Experience { get => _experience; }    

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