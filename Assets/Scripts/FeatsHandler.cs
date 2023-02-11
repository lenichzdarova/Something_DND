
using System.Collections.Generic;

public class FeatsHandler
{
    private List<Feat> _feats;
    public List<Feat> Feats { get => _feats; }

    public FeatsHandler(RaceEnum race, ClassEnum characterClass)//fists lvl character constructor
    {
        int characterLevel = 1;
        _feats = new List<Feat>();
        _feats.AddRange(RaceFeatsProvider.GetFeats(race));
        _feats.AddRange(ClassFeatsProvider.GetFeats(characterClass, characterLevel));
    }

    public void AddFeat(Feat feat)
    {
        _feats.Add(feat);
    }

    public void RemoveFeat(Feat feat)
    {
        _feats.Remove(feat);
    }

    public List<IAbilitiesProvider> GetAbilitiesFeats() 
    { 
        List<IAbilitiesProvider> result = new List<IAbilitiesProvider>();
        foreach (Feat feat in _feats)
        {
            if(feat is IAbilitiesProvider provider)
            {
                result.Add(provider);
            }
        }
        return result;
    }

    public List<IAttackProvider> GetAttackFeats()
    {
        List<IAttackProvider> result = new List<IAttackProvider>();
        foreach (Feat feat in _feats)
        {
            if (feat is IAttackProvider provider)
            {
                result.Add(provider);
            }
        }
        return result;
    }

    public List<ISavingThrowsProvider> GetSavingThrowFeats()
    {
        List<ISavingThrowsProvider> result = new List<ISavingThrowsProvider>();
        foreach (Feat feat in _feats)
        {
            if (feat is ISavingThrowsProvider provider)
            {
                result.Add(provider);
            }
        }
        return result;
    }

    public List<IDamageProvider> GetDamageFeats()
    {
        List<IDamageProvider> result = new List<IDamageProvider>();
        foreach (Feat feat in _feats)
        {
            if (feat is IDamageProvider provider)
            {
                result.Add(provider);
            }
        }
        return result;
    }


}
