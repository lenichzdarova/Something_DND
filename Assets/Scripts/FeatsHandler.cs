
using System;
using System.Collections.Generic;

public class FeatsHandler
{
    public event Action Changed;

    private List<Feat> _feats;
    public List<Feat> Feats { get => _feats; }

    public FeatsHandler()
    {        
        _feats = new List<Feat>();        
    }

    public void AddFeat(List<Feat> feats)
    {
        _feats.AddRange(feats);
        Changed?.Invoke();
    }

    public void AddFeat(Feat feat)
    {
        _feats.Add(feat);
        Changed?.Invoke();
    }

    public void RemoveFeat(Feat feat)
    {        
        _feats.Remove(feat);
        Changed?.Invoke();
    }

    public void RemoveFeat(List<Feat> feats)
    {
        foreach(var feat in feats)
        {
            _feats.Remove(feat);            
        }
        Changed?.Invoke();
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
