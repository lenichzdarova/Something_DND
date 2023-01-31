

using System.Collections.Generic;

public class Combat
{
    private List<Character> _combatants;
    private Round _currentRound;

    public Combat(List<Character> combatants)
    {
        _combatants = combatants;
        RoundStart();
    }

    private void OnRoundEnd()
    {
        if (true) //here i must to know do player have enemies//
        {
            RoundStart();
        }
    }

    private void RoundStart()
    {
        _currentRound = new Round(_combatants);
        _currentRound.RoundEnd += OnRoundEnd;
    }
}
