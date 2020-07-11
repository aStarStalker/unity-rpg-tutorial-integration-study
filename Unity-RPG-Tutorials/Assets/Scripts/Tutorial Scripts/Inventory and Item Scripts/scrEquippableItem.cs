using UnityEngine;

public enum EquipmentType
{
    Weapon,
    Headgear,
    Bodygear,
    Handgear,
    Accessory,
    Footwear
}

[CreateAssetMenu]
public class scrEquippableItem : scrItem
{
    public int MaxHPBonus;
    public int MaxMPBonus;
    public int AttackBonus;
    public int SpAttackBonus;
    public int DefenseBonus;
    public int SpDefenseBonus;
    public int SpeedBonus;
    public int LuckBonus;
    [Space]
    public float MaxHPPercentPercent;
    public float MaxMPPercentBonus;
    public float AttackPercentBonus;
    public float SpAttackPercentBonus;
    public float DefensePercentBonus;
    public float SpDefensePercentBonus;
    public float SpeedPercentBonus;
    [Space]
    public EquipmentType EquipmentType;
}
