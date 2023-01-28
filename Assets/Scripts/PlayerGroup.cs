

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UnityEngine;

public class PlayerGroup
{
    public event Action GroupChanged;

    public const int MAX_CHARACTER_COUNT = 6;
    private List<Character> _characters;    

    public PlayerGroup()
    {
        _characters = new List<Character>();
    }

    public void AddCharacter(Character character)
    {
        if(_characters.Count < MAX_CHARACTER_COUNT)
        {
            _characters.Add(character);
            GroupChangedInvoke();
        }
        else
        {
            //here must be event invocation about group is full - remove somebody first
            Debug.Log("Group is full");
        }
    }

    public void RemoveCharacter(int index) 
    {
        _characters.RemoveAt(index);
        GroupChangedInvoke();
    }

    public Character GetCharacter(int index) 
    {
        if(index < _characters.Count)
        {
            return _characters[index];
        }
        else
        {
            return _characters.Last();
        }
    } 
    
    private void GroupChangedInvoke()
    {        
        GroupChanged?.Invoke();
    }

    public ReadOnlyCollection<Character> GetCharacters()
    {

        var characters = _characters.AsReadOnly();
        return characters;        
    }
}
