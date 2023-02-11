
public class AbilitiesHandler
{
    private FeatsHandler _featsHandler;
    private Abilities _baseAbilities;

    public AbilitiesHandler(Abilities baseAbilities, FeatsHandler featsHandler)
    {
        _baseAbilities= baseAbilities;
        _featsHandler= featsHandler;
    }

    public Abilities GetAbilities()
    {
        Abilities result = _baseAbilities;
        var feats = _featsHandler.GetAbilitiesFeats();
        foreach (var feat in feats)
        {
            result += feat.GetAbilities();
        }
        //sum IabilitiesProvider from effects and feats
        return result;
    }
}
