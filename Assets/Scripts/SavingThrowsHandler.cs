
using System;

public class SavingThrowsHandler
{
    public event Action Changed;

    private FeatsHandler _featsHandler;
    private AbilitiesHandler _abilitiesHandler;
    
    private SavingThrows _finalValue;

    public SavingThrowsHandler(FeatsHandler featsHandler,AbilitiesHandler abilitiesHandler)
    {
        _featsHandler = featsHandler;
        _featsHandler.Changed += OnChanged;
        _abilitiesHandler = abilitiesHandler;
        abilitiesHandler.Changed += OnChanged;
    }

    private void Calculate()
    {
        SavingThrows result = new SavingThrows();
        result += AbilitiesSavingThrows();
        var feats = _featsHandler.GetSavingThrowFeats();
        foreach (var feat in feats)
        {
            result += feat.GetSavingThrows();
        }

        Changed?.Invoke();
    }

    private SavingThrows AbilitiesSavingThrows()
    {
        Abilities abilities = _abilitiesHandler.GetAbilities();
        SavingThrows result = new SavingThrows();
        result.Fortitude = abilities.GetConstitutionBonus();
        result.Reflex = abilities.GetDexterityBonus();
        result.Will = abilities.GetWisdomBonus();
        return result;
    }

    public SavingThrows GetSavingThrows()
    {
        return _finalValue;
    }

    private void OnChanged()
    {
        Calculate();
    }
}
