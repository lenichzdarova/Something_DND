
using System;
using System.Collections.Generic;
using UnityEngine;

public class Round
{
    public event Action RoundEnd;

    private Queue<Character> _actionOrder;

    public Round(List<Character> combatants)
    {
        //i must implement term to sort characters to queue;
    }

    public void OnCharacterSpentAction()
    {
        _actionOrder.Dequeue();
        if(_actionOrder.Count == 0 ) 
        {
            RoundEnd?.Invoke();
        }
    }
}
