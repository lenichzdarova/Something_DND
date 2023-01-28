using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData 
{
    private Character _character;
    //questdata -- this maybe not right; maybe need standalone quest system.
    //etc

    public IInventoryDataProvider GetInventoryData()
    {
        return _character;
    }
}
