using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

[Serializable]
public class scrUnitStatsTutorial
{
    public float BaseValue;

    public float ModifierValue {
        get {
            if (isDirty || BaseValue != lastBaseValue) {
                lastBaseValue = BaseValue;
                _recentValue = CalculateFinalStatValue();
                isDirty = false;

            } return _recentValue;
        }
    }

    protected bool isDirty = true;
    protected float _recentValue;
    protected float lastBaseValue = float.MinValue;

    protected readonly List<scrUnitStatModifiersTutorial> statModifiers;
    public readonly ReadOnlyCollection<scrUnitStatModifiersTutorial> StatModifiers;

    

    public scrUnitStatsTutorial()
    {
        statModifiers = new List<scrUnitStatModifiersTutorial>();
        StatModifiers = statModifiers.AsReadOnly();
    }

    public scrUnitStatsTutorial(float baseValue) : this()
    {
        BaseValue = baseValue;
    }

    public void AddModifier(scrUnitStatModifiersTutorial modifier)
    {
        isDirty = true;
        statModifiers.Add(modifier);
        statModifiers.Sort(CompareModifierOrder);
    }

    protected int CompareModifierOrder(scrUnitStatModifiersTutorial a, scrUnitStatModifiersTutorial b)
    {
        if (a.ModifierOrder < b.ModifierOrder)
            return -1;
        else if (a.ModifierOrder > b.ModifierOrder)
            return 1;
        return 0; //if (a.ModifierOrder == b.ModifierOrder)
    }

    public bool RemoveModifier(scrUnitStatModifiersTutorial modifier)
    {
        if (statModifiers.Remove(modifier))
        {
            isDirty = true;
            return true;
        }
        return false;
    }

    public bool RemoveAllModsFromSource(object source)
    {
        bool didRemove = false;

        for (int i = statModifiers.Count - 1; i >= 0; i--)
        {
            if (statModifiers[i].ModifierSource == source)
            {
                isDirty = true;
                didRemove = true;
                statModifiers.RemoveAt(i);
            }
        }
        return didRemove;
    }

    protected float CalculateFinalStatValue()
    {
        float finalValue = BaseValue;
        float sumPercentAdd = 0;

        for (int i = 0; i < statModifiers.Count; i++)
        {
            scrUnitStatModifiersTutorial mod = statModifiers[i];

            if (mod.ModifierType == StatModType.Flat)
            {
                finalValue += mod.ModifierValue;
            }
            else if (mod.ModifierType == StatModType.PercentAdd)
            {
                sumPercentAdd += mod.ModifierValue;

                if (i + 1 > statModifiers.Count || statModifiers[i + 1].ModifierType != StatModType.PercentAdd)
                {
                    finalValue *= sumPercentAdd;
                    sumPercentAdd = 0;
                }
            }
            else if (mod.ModifierType == StatModType.PercentMult)
            {
                finalValue *= 1 + mod.ModifierValue;
            }
        }

        return (float)Math.Round(finalValue, 4);
    }
}
