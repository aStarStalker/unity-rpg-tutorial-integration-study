
public enum StatModType
{
    Flat = 100,
    PercentAdd = 200,
    PercentMult = 300,
}

public class scrUnitStatModifiersTutorial
{
    public readonly float ModifierValue;
    public readonly StatModType ModifierType;
    public readonly int ModifierOrder;
    public readonly object ModifierSource;

    public scrUnitStatModifiersTutorial(float modifierValue, StatModType modifierType, int modifierOrder, object modifierSource)
    {
        ModifierValue = modifierValue;
        ModifierType = modifierType;
        ModifierOrder = modifierOrder;
        ModifierSource = modifierSource;
    }

    public scrUnitStatModifiersTutorial(float modifierValue, StatModType modifierType) : this(modifierValue, modifierType, (int)modifierType, null) { }

    public scrUnitStatModifiersTutorial(float modifierValue, StatModType modifierType, int modifierOrder) : this(modifierValue, modifierType, modifierOrder, null) { }

    public scrUnitStatModifiersTutorial(float modifierValue, StatModType modifierType, object modifierSource) : this(modifierValue, modifierType, (int)modifierType, modifierSource) { }
}
