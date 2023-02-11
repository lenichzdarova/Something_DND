
using System;

public class AbilitiesHandler
{
    public event Action Changed;

    private FeatsHandler _featsHandler;
    private Abilities _baseAbilities; //pure value without any effects
    private Abilities _finalValue;

    public AbilitiesHandler(Abilities baseAbilities, FeatsHandler featsHandler)
    {
        _baseAbilities= baseAbilities;
        _featsHandler= featsHandler;
        _featsHandler.Changed += OnChange;
        Calculate();
    }

    public void AddAbilities(Abilities abilities)
    {
        _baseAbilities += abilities;
        Changed?.Invoke();
    }

    public Abilities GetAbilities()
    {        
        return _finalValue;
    }
    private void Calculate()
    {
        Abilities result = _baseAbilities;
        var feats = _featsHandler.GetAbilitiesFeats();
        foreach (var feat in feats)
        {
            result += feat.GetAbilities();
        }
        //sum IabilitiesProvider from effects and feats
        _finalValue = result;
    }

    private void OnChange()
    {
        Calculate();
        Changed?.Invoke();
    }
}
