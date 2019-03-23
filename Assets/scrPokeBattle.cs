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

    public bool Burn;
    // true = 0.5;
    // false = 1.0;

    public int Weather;
    // 0 = None
    // 1 = Rain
    // 2 = Sunlight
    #endregion

    void Start()
    {
        LevelCap();
    }

    #region Level Adjust
    int LevelCap(int PokeLevel)
    {
        int Level;
        if (PokeLevel < 1) {
            Level = 1;
        } else if (PokeLevel > 100) {
            Level = 100;
        }

        return Level;
    }
    #endregion

    #region Attack Power Adjust
    int AttackPower(int AtkPower)
    {
        int AtkPow;
        if (AtkPower < 0) {
            AtkPow = 0;
        } else if (AtkPower > 255) {
            AtkPow = 255;
        }

        return AtkPow;
    }
    #endregion

    #region Pokemon Attack
    int PokemonAttack(int PokeAtk)
    {
        int PkAtk;
        if (PokeAtk < 0) {
            PkAtk = 0;
        } else if (PokeAtk > 999) {
            PkAtk = 999;
        }

        return PkAtk;
    }
    #endregion

    #region Pokemon Type
    int PokeType(int Type)
    {
        switch (Type) {
            case 0:
                Type = Normal;
                break;
            case 1:
                Type = Fire;
                break;
            case 2:
                Type = Water;
                break;
            case 3:
                Type = Electric;
                break;
            case 4:
                Type = Grass;
                break;
            case 5:
                Type = Ice;
                break;
            case 6:
                Type = Fighting;
                break;
            case 7:
                Type = Poison;
                break;
            case 8:
                Type = Ground;
                break;
            case 9:
                Type = Flying;
                break;
            case 10:
                Type = Psychic;
                break;
            case 11:
                Type = Bug;
                break;
            case 12:
                Type = Rock;
                break;
            case 13:
                Type = Ghost;
                break;
            case 14:
                Type = Dragon;
                break;
            case 15:
                Type = Dark;
                break;
            case 16:
                Type = Steel;
                break;
            case 17:
                Type = Fairy;
                break;
            default:
                Type = None;
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
                Type = Normal;
                break;
            case 1:
                Type = Fire;
                break;
            case 2:
                Type = Water;
                break;
            case 3:
                Type = Electric;
                break;
            case 4:
                Type = Grass;
                break;
            case 5:
                Type = Ice;
                break;
            case 6:
                Type = Fighting;
                break;
            case 7:
                Type = Poison;
                break;
            case 8:
                Type = Ground;
                break;
            case 9:
                Type = Flying;
                break;
            case 10:
                Type = Psychic;
                break;
            case 11:
                Type = Bug;
                break;
            case 12:
                Type = Rock;
                break;
            case 13:
                Type = Ghost;
                break;
            case 14:
                Type = Dragon;
                break;
            case 15:
                Type = Dark;
                break;
            case 16:
                Type = Steel;
                break;
            case 17:
                Type = Fairy;
                break;
            default:
                Type = None;
                break;
        }

        return AtkType;
    }
    #endregion

    #region Targets
    int Target(int Targets)
    {
        double TargetDmg = 1.00;
        if (Targets == 1) {
        } else if (Targets >= 2) {
            TargetDmg *= 0.75;
        } else if (Targets <= 0) {
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
                TgtType1 = Normal;
                break;
            case 1:
                TgtType1 = Fire;
                break;
            case 2:
                TgtType1 = Water;
                break;
            case 3:
                TgtType1 = Electric;
                break;
            case 4:
                TgtType1 = Grass;
                break;
            case 5:
                TgtType1 = Ice;
                break;
            case 6:
                TgtType1 = Fighting;
                break;
            case 7:
                TgtType1 = Poison;
                break;
            case 8:
                TgtType1 = Ground;
                break;
            case 9:
                TgtType1 = Flying;
                break;
            case 10:
                TgtType1 = Psychic;
                break;
            case 11:
                TgtType1 = Bug;
                break;
            case 12:
                TgtType1 = Rock;
                break;
            case 13:
                TgtType1 = Ghost;
                break;
            case 14:
                TgtType1 = Dragon;
                break;
            case 15:
                TgtType1 = Dark;
                break;
            case 16:
                TgtType1 = Steel;
                break;
            case 17:
                TgtType1 = Fairy;
                break;
            default:
                TgtType1 = None;
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
                TgtType2 = Normal;
                break;
            case 1:
                TgtType2 = Fire;
                break;
            case 2:
                TgtType2 = Water;
                break;
            case 3:
                TgtType2 = Electric;
                break;
            case 4:
                TgtType2 = Grass;
                break;
            case 5:
                TgtType2 = Ice;
                break;
            case 6:
                TgtType2 = Fighting;
                break;
            case 7:
                TgtType2 = Poison;
                break;
            case 8:
                TgtType2 = Ground;
                break;
            case 9:
                TgtType2 = Flying;
                break;
            case 10:
                TgtType2 = Psychic;
                break;
            case 11:
                TgtType2 = Bug;
                break;
            case 12:
                TgtType2 = Rock;
                break;
            case 13:
                TgtType2 = Ghost;
                break;
            case 14:
                TgtType2 = Dragon;
                break;
            case 15:
                TgtType2 = Dark;
                break;
            case 16:
                TgtType2 = Steel;
                break;
            case 17:
                TgtType2 = Fairy;
                break;
            default:
                TgtType2 = None;
                break;
        }

        return TgtType2;
    }
    #endregion

    #region Weather
    int Wther(int Weather)
    {
        double WeatherDmg = 1.00;
        if (Weather == 1) {
            if (AtkType == 2) {
                WeatherDmg = 2.00;
            } else if (AtkType == 1) {
                WeatherDmg = 0.50;
            }
        } else if (Weather == 2) {
            if (AtkType == 1) {
                WeatherDmg = 2.00;
            } else if (AtkType == 2) {
                WeatherDmg = 0.50;
            }
        }

        return WeatherDmg;
    }
    #endregion

    #region Critical Hit
    bool isCrit()
    {
        double lucky = Random.Range(0, 15);
        if (lucky = 15) {
            bool isCrit = true;
            double Crit = 1;
            if (isCrit) {
                Crit = 1.5;
            }
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
        if (PokeType == AtkType) {
            STAB = 1.5;
        }

        return STAB;
    }
    #endregion

    #region Burn
    bool isBurn()
    {
        bool isBurn = true;
        double Burn = 1;
        if (isBurn) {
            Burn = 0.5;
        }

        return Burn;
    }
    #endregion

    #region Multiplier
    double Multiplier(int AtkType,int TgtType1,int TgtType2)
    {
        double Multi;

            // Normal
        if (AtkType = 0 && TgtType1 = 13 || TgtType2 = 13) {
            Multi = 0;
        } else if (AtkType = 0 && TgtType1 = 12 || TgtType1 = 16) {
            Multi = 0.5;
            if (AtkType = 0 && TgtType2 = 12 || TgtType2 = 16) {
                Multi = 0.25;
            }
        } 
            // Fire 
        else if (AtkType = 1 && TgtType1 = 1 || TgtType1 = 2 || TgtType1 = 12 || TgtType1 = 14) {
            Multi = 0.5;
            if (AtkType = 1 && TgtType2 = 1 || TgtType2 = 2 || TgtType2 = 12 || TgtType2 = 14) {
                Multi = 0.25;
            }
        } else if (AtkType = 1 && TgtType1 = 4 || TgtType1 = 5 || TgtType1 = 11 || TgtType1 = 16) {
            Multi = 2;
            if (AtkType = 1 && TgtType2 = 4 || TgtType2 = 5 || TgtType2 = 11 || TgtType2 = 16) {
                Multi = 4;
            }
        }
            // Water
        else if (AtkType = 2 && TgtType1 = 2 || TgtType1 = 4 || TgtType1 = 14) {
            Multi = 0.5;
            if (AtkType = 2 && TgtType1 = 2 || TgtType1 = 4 || TgtType1 = 14) {
                Multi = 0.25;
            }
        } else if (AtkType = 2 && TgtType1 = 1 || TgtType1 = 8 || TgtType1 = 12) {
            Multi = 2;
            if (AtkType = 2 && TgtType1 = 1 || TgtType1 = 8 || TgtType1 = 12) {
                Multi = 4;
            }
        }
    }
    #endregion

    #region Modifier
    double Mdf(double TargetDmg, double WeatherDmg, double Crit, double Rand, double STAB,double Multi, double Burn)
    {
        var Modifier = TargetDmg * Weather * Crit * Rand * STAB * Multi * Burn;
        Dmg(Modifier);
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
