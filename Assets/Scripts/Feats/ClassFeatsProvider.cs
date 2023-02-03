

using System.Collections.Generic;

public class ClassFeatsProvider : ICharacterFeatsProvider
{
    private readonly ClassType _classType;

    public ClassFeatsProvider(ClassType classType)
    {
        _classType = classType;
    }
    
    public List<CharacterFeat> GetCharacterFeats()
    {

    }
}
