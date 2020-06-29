using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrUnitStats : MonoBehaviour
{
    // Variable declaration section

    // Basic Unit parameters
    public string UnitName;
    public string UnitClass;

    public float UnitRank;
    public float UnitBaseTurnCount;

    public float UnitMaxHP;
    public float UnitCurrentHP;
    public float UnitMaxMP;
    public float UnitCurrentMP;

    public float UnitAttack;
    public float UnitDefense;
    public float UnitSpAttack;
    public float UnitSpDefense;
    public float UnitSpeed;
    public float UnitLuck;

    public float[] UnitCurrentMinorAilments; /* 0 = none, 1 = Burn, 2 = Soak, 3 = Shock, 4 = Shake, 5 = Confuse, 6 = Chill,
                                              * 7 = Wounded, 8 = Daze
                                              */
    public float[] UnitCurrentAilments; /* 0 = none, 1 = Delusion, 2 = Stun, 3 = Sleep, 4 = Deep Sleep 5 = Seal, 6 = Fatigue,
                                         * 7 = (Death)Curse, 8 = Poison/Venom, 9 = Deadly Poison/Venom, 10 = Equip Curse, 11 = Haunt,
                                         * 12 = Freeze, 13 = Shock, 14 = Paralyze, 15 = Charm, 16 = Stone, 17 = Bind, 18 = Happy,
                                         * 19 = Rage, 20 = Swept, 21 = Hungry, 22 = Sick, 23 = Guilt, 24 = Cloak, 25 = Puppet,
                                         * 26 = Despair, 27 = Panic
                                         */

    // Modifiers applied mid-battle
    public float UnitLifeState; // 0 = alive, -1 = dead, -2 = final death, -3 = puppet, -4 = petrified

    public float UnitMaxHPMod;
    public float UnitMaxMPMod;

    public float UnitAttackMod;
    public float UnitDefenseMod;
    public float UnitSpAttackMod;
    public float UnitSpDefenseMod;
    public float UnitSpeedMod;

    public float UnitAccuracyMod;
    public float UnitEvasionMod;
    public float UnitCritMod;
    public float UnitLuckMod;
    public float UnitAilmentChanceMod;


    // Methods for unit self-maintenance, to prevent game rules from being broken and updating its own status.
    void UnitHPandMPMaintenance() // Method called whenever HP/MP is changed in any way
    {
        if (this.UnitCurrentHP >= this.UnitMaxHP) this.UnitCurrentHP = this.UnitMaxHP;
        if (this.UnitCurrentMP >= this.UnitMaxMP) this.UnitCurrentMP = this.UnitMaxMP;
    }

    void UnitLifeStateMaintenance()
    {
        if (this.UnitCurrentHP <= 0)
        {
            this.UnitCurrentHP = 0;
            this.UnitLifeState = -1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
