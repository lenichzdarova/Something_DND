
using System;

public class GameDateTime
{
    private DateTime _date;

    public GameDateTime(DateTime current = default)
    {
        if(current == default)
        {
            DateTime startGameDefaulDateTime = new DateTime(1680, 1, 10);
            _date = startGameDefaulDateTime;
        }
        _date = current;
    }    
}
