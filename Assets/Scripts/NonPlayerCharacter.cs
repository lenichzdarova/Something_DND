

using UnityEngine;

/// <summary>
/// NPC have serialized field with character creation parameters
/// or i have enum npcType and have all types parameters database.
/// 
/// both aproach shitty i think.
/// </summary>
public class NonPlayerCharacter: MonoBehaviour
{
    private Character _character;    

    public void Initialize()
    {
        _character = new Character();        
    }

}
