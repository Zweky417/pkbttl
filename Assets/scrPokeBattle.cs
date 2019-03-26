using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPokeBattle : MonoBehaviour
{
    #region Public
    public int PokeLevel;
    // 1 ~~ 100

    public int AtkPower;
    // 0 ~~ 255
    #region Some attacks and their Atk Power
    // 250 / Explosion     / Normal
    // 200 / Self-Destruct / Normal
    // 150 / Hyper Beam    / Normal
    // 120 / Solar Beam    / Grass
    // 120 / Superpower    / Fighting
    // 120 / Outrage       / Dragon
    // 110 / Fire Blast    / Fire
    // 110 / Hydro Pump    / Water
    // 110 / Thunder       / Electric
    // 110 / Blizzard      / Ice
    // 100 / Earthquake    / Ground   / 3 Targets
    // 100 / Stone Edge    / Rock
    // 100 / Iron Tail     / Steel
    //  95 / Surf          / Water
    //  95 / Sludge Bomb   / Poison
    //  95 / Moonblast     / Fairy
    //  90 / Flamethrower  / Fire
    //  90 / Thunderbolt   / Electric
    //  90 / Ice Beam      / Ice
    //  90 / Fly           / Flying
    //  90 / Psychic       / Psychic
    //  80 / Dig           / Ground
    //  80 / Leech Life    / Bug
    //  80 / Shadow Ball   / Ghost
    //  80 / Dragon Claw   / Dragon
    //  80 / Crunch        / Dark
    //  75 / Giga Drain    / Grass
    //  75 / Rock Slide    / Rock
    //  70 / Steel Wing    / Steel
    //  65 / Sludge        / Poison
    //  65 / Psybeam       / Psychic
    //  60 / Wing Attack   / Flying
    //  60 / Bite          / Dark
    //  55 / Razor Leaf    / Grass
    //  55 / Icy Wind      / Ice
    //  50 / Scratch       / Normal
    //  50 / Confusion     / Psychic
    //  50 / Rock Throw    / Rock
    //  50 / Metal Claw    / Steel
    //  40 / Tackle        / Normal
    //  40 / Ember         / Fire
    //  40 / Bubble        / Water    / 2 Targets
    //  40 / Water Gun     / Water
    //  40 / Thunder Shock / Electric
    //  40 / Rock Smash    / Fighting
    //  40 / Gust          / Flying
    //  40 / Fairy Wind    / Fairy
    //  35 / Peck          / Flying
    //  30 / Double Kick   / Fighting
    //  30 / Lick          / Ghost
    //  20 / Absorb        / Grass
    //  20 / Mud-Slap      / Ground
    //  15 / Poison Sting  / Poison
    #endregion

    public int PokeAtk;
    // 0 ~~ 999

    public int Type;
    // 0 = Normal // 1 = Fire // 2 = Water // 3 = Electric // 4 = Grass // 5 = Ice
    // 6 = Fighting // 7 = Poison // 8 = Ground // 9 = Flying // 10 = Psychic // 11 = Bug
    // 12 = Rock // 13 = Ghost // 14 = Dragon // 15 = Dark // 16 = Steel // 17 = Fairy // Other = None

    public int AtkType;
    // 0 = Normal // 1 = Fire // 2 = Water // 3 = Electric // 4 = Grass // 5 = Ice
    // 6 = Fighting // 7 = Poison // 8 = Ground // 9 = Flying // 10 = Psychic // 11 = Bug
    // 12 = Rock // 13 = Ghost // 14 = Dragon // 15 = Dark // 16 = Steel // 17 = Fairy // Other = None

    public int Targets;
    // 0 = 0.00x;
    // 1 = 1.00x;
    // 2+= 0.75x;

    public int TgtType1;
    // 0 = Normal // 1 = Fire // 2 = Water // 3 = Electric // 4 = Grass // 5 = Ice
    // 6 = Fighting // 7 = Poison // 8 = Ground // 9 = Flying // 10 = Psychic // 11 = Bug
    // 12 = Rock // 13 = Ghost // 14 = Dragon // 15 = Dark // 16 = Steel // 17 = Fairy // Other = None

    public int TgtType2;
    // 0 = Normal // 1 = Fire // 2 = Water // 3 = Electric // 4 = Grass // 5 = Ice
    // 6 = Fighting // 7 = Poison // 8 = Ground // 9 = Flying // 10 = Psychic // 11 = Bug
    // 12 = Rock // 13 = Ghost // 14 = Dragon // 15 = Dark // 16 = Steel // 17 = Fairy // Other = None

    public int Burned;
    // true = 0.5;
    // false = 1.0;

    public int Weather;
    // 0 = None
    // 1 = Rain
    // 2 = Sunlight
    #endregion

    void Start()
    {
        LevelCap(PokeLevel);
    }

    #region Level Adjust
    int LevelCap(int PokeLevel)
    {
        int Level = PokeLevel;
        if (PokeLevel < 1)
        {
            Level = 1;
        }
        else if (PokeLevel > 100)
        {
            Level = 100;
        }

        return Level;
    }
    #endregion

    #region Attack Power Adjust
    int AttackPower(int AtkPower)
    {
        int AtkPow = AtkPower;
        if (AtkPower < 0)
        {
            AtkPow = 0;
        }
        else if (AtkPower > 255)
        {
            AtkPow = 255;
        }

        return AtkPow;
    }
    #endregion

    #region Pokemon Attack
    int PokemonAttack(int PokeAtk)
    {
        int PkAtk = PokeAtk;
        if (PokeAtk < 0)
        {
            PkAtk = 0;
        }
        else if (PokeAtk > 999)
        {
            PkAtk = 999;
        }

        return PkAtk;
    }
    #endregion

    #region Pokemon Type
    int PokeType(int Type)
    {
        switch (Type)
        {
            case 0:
                Type = 0;
                break;
            case 1:
                Type = 1;
                break;
            case 2:
                Type = 2;
                break;
            case 3:
                Type = 3;
                break;
            case 4:
                Type = 4;
                break;
            case 5:
                Type = 5;
                break;
            case 6:
                Type = 6;
                break;
            case 7:
                Type = 7;
                break;
            case 8:
                Type = 8;
                break;
            case 9:
                Type = 9;
                break;
            case 10:
                Type = 10;
                break;
            case 11:
                Type = 11;
                break;
            case 12:
                Type = 12;
                break;
            case 13:
                Type = 13;
                break;
            case 14:
                Type = 14;
                break;
            case 15:
                Type = 15;
                break;
            case 16:
                Type = 16;
                break;
            case 17:
                Type = 17;
                break;
            default:
                Type = 18;
                break;
        }

        return Type;
    }
    #endregion

    #region Attack Type
    int AttackType(int AtkType)
    {
        switch (AtkType)
        {
            case 0:
                AtkType = 0;
                break;
            case 1:
                AtkType = 1;
                break;
            case 2:
                AtkType = 2;
                break;
            case 3:
                AtkType = 3;
                break;
            case 4:
                AtkType = 4;
                break;
            case 5:
                AtkType = 5;
                break;
            case 6:
                AtkType = 6;
                break;
            case 7:
                AtkType = 7;
                break;
            case 8:
                AtkType = 8;
                break;
            case 9:
                AtkType = 9;
                break;
            case 10:
                AtkType = 10;
                break;
            case 11:
                AtkType = 11;
                break;
            case 12:
                AtkType = 12;
                break;
            case 13:
                AtkType = 13;
                break;
            case 14:
                AtkType = 14;
                break;
            case 15:
                AtkType = 15;
                break;
            case 16:
                AtkType = 16;
                break;
            case 17:
                AtkType = 17;
                break;
            default:
                AtkType = 18;
                break;
        }

        return AtkType;
    }
    #endregion

    #region Targets
    double Target(int Targets)
    {
        double TargetDmg = 1.00;
        if (Targets == 1)
        {
        }
        else if (Targets >= 2)
        {
            TargetDmg *= 0.75;
        }
        else if (Targets <= 0)
        {
            TargetDmg *= 0.00;
        }

        return TargetDmg;
    }
    #endregion

    #region Target Type 1
    int TargetType1(int TgtType1)
    {
        switch (TgtType1)
        {
            case 0:
                TgtType1 = 0;
                break;
            case 1:
                TgtType1 = 1;
                break;
            case 2:
                TgtType1 = 2;
                break;
            case 3:
                TgtType1 = 3;
                break;
            case 4:
                TgtType1 = 4;
                break;
            case 5:
                TgtType1 = 5;
                break;
            case 6:
                TgtType1 = 6;
                break;
            case 7:
                TgtType1 = 7;
                break;
            case 8:
                TgtType1 = 8;
                break;
            case 9:
                TgtType1 = 9;
                break;
            case 10:
                TgtType1 = 10;
                break;
            case 11:
                TgtType1 = 11;
                break;
            case 12:
                TgtType1 = 12;
                break;
            case 13:
                TgtType1 = 13;
                break;
            case 14:
                TgtType1 = 14;
                break;
            case 15:
                TgtType1 = 15;
                break;
            case 16:
                TgtType1 = 16;
                break;
            case 17:
                TgtType1 = 17;
                break;
            default:
                TgtType1 = 18;
                break;
        }

        return TgtType1;
    }
    #endregion

    #region Target Type 2
    int TargetType2(int TgtType2)
    {
        switch (TgtType2)
        {
            case 0:
                TgtType2 = 0;
                break;
            case 1:
                TgtType2 = 1;
                break;
            case 2:
                TgtType2 = 2;
                break;
            case 3:
                TgtType2 = 3;
                break;
            case 4:
                TgtType2 = 4;
                break;
            case 5:
                TgtType2 = 5;
                break;
            case 6:
                TgtType2 = 6;
                break;
            case 7:
                TgtType2 = 7;
                break;
            case 8:
                TgtType2 = 8;
                break;
            case 9:
                TgtType2 = 9;
                break;
            case 10:
                TgtType2 = 10;
                break;
            case 11:
                TgtType2 = 11;
                break;
            case 12:
                TgtType2 = 12;
                break;
            case 13:
                TgtType2 = 13;
                break;
            case 14:
                TgtType2 = 14;
                break;
            case 15:
                TgtType2 = 15;
                break;
            case 16:
                TgtType2 = 16;
                break;
            case 17:
                TgtType2 = 17;
                break;
            default:
                TgtType2 = 18;
                break;
        }

        return TgtType2;
    }
    #endregion

    #region Weather
    double Wther(int Weather)
    {
        double WeatherDmg = 1.00;
        if (Weather == 1)
        {
            if (AtkType == 2)
            {
                WeatherDmg = 2.00;
            }
            else if (AtkType == 1)
            {
                WeatherDmg = 0.50;
            }
        }
        else if (Weather == 2)
        {
            if (AtkType == 1)
            {
                WeatherDmg = 2.00;
            }
            else if (AtkType == 2)
            {
                WeatherDmg = 0.50;
            }
        }

        return WeatherDmg;
    }
    #endregion

    #region Critical Hit
    double Critical()
    {
        double lucky = Random.Range(0, 15);
        double Crit = 1;

        if (lucky == 15)
        {
            Crit = 1.5;
        }

        return Crit;
    }
    #endregion

    #region Random Value
    double RandomValue()
    {
        double Rand = Random.Range(217, 255) / 255;

        return Rand;
    }
    #endregion

    #region SameTypeAttackBonus(STAB)
    double Stab(double STAB)
    {
        if (Type == AtkType)
        {
            STAB = 1.5;
        }

        return STAB;
    }
    #endregion

    #region Burn
    double isBurn()
    {
        double Burn = Burned;
        if (Burned >= 1)
        {
            Burn = 0.5;
        }

        return Burn;
    }
    #endregion

    #region Multiplier
    double Multiplier(int AtkType, int TgtType1, int TgtType2)
    {
        double Multi;

        // Normal
        if (AtkType = 0 && TgtType1 = 13 | |TgtType2 = 13)
        {
            Multi = 0;
        }
        else if (AtkType = 0 && TgtType1 = 12 || TgtType1 = 16)
        {
            Multi = 0.5;
            if (AtkType = 0 && TgtType2 = 12 || TgtType2 = 16)
            {
                Multi = 0.25;
            }
        }
        // Fire 
        else if (AtkType = 1 && TgtType1 = 1 || TgtType1 = 2 || TgtType1 = 12 || TgtType1 = 14)
        {
            Multi = 0.5;
            if (AtkType = 1 && TgtType2 = 1 || TgtType2 = 2 || TgtType2 = 12 || TgtType2 = 14)
            {
                Multi = 0.25;
            }
        }
        else if (AtkType = 1 && TgtType1 = 4 || TgtType1 = 5 || TgtType1 = 11 || TgtType1 = 16)
        {
            Multi = 2;
            if (AtkType = 1 && TgtType2 = 4 || TgtType2 = 5 || TgtType2 = 11 || TgtType2 = 16)
            {
                Multi = 4;
            }
        }
        // Water
        else if (AtkType = 2 && TgtType1 = 2 || TgtType1 = 4 || TgtType1 = 14)
        {
            Multi = 0.5;
            if (AtkType = 2 && TgtType1 = 2 || TgtType1 = 4 || TgtType1 = 14)
            {
                Multi = 0.25;
            }
        }
        else if (AtkType = 2 && TgtType1 = 1 || TgtType1 = 8 || TgtType1 = 12)
        {
            Multi = 2;
            if (AtkType = 2 && TgtType1 = 1 || TgtType1 = 8 || TgtType1 = 12)
            {
                Multi = 4;
            }
        }
    }
    #endregion

    #region Modifier
    double Mdf(double TargetDmg, double WeatherDmg, double Crit, double Rand, double STAB, double Multi, double Burn)
    {
        var Modifier = TargetDmg * Weather * Crit * Rand * STAB * Multi * Burn;
        return Modifier;
    }
    #endregion

    #region Damage
    double Dmg(int Level, int AtkPow, int PkAtk, double Modifier)
    {
        var Damage = ((((((2 * Level) / 5) + 2) * AtkPow * PkAtk) / 50) + 2) * Modifier;
        return Damage;
    }
    #endregion
}
