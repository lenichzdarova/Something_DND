using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData 
{
    private Character _character;

    public IInventoryDataProvider GetInventoryData()
    {
        return _character;
    }
}
