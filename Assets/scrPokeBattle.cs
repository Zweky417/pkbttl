using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPokeBattle : MonoBehaviour {

    public int Level;
    public int AtkPower;
    public int PokeAtk;
    public int PokeType;
    public int AtkType;
    public int Targets;
    // 1 = 1.00x;
    // 2+= 0.75x;
    public bool Burn;
    // true = 0.5;
    // false = 1.0;
    public int Weather;
    // 0 = None
    // 1 = Rain
    // 2 = Sunlight

	void Start () 
    {
        double Damage, Modifier, STAB = 1.0;
    
	}

    void Tgts(double Damage)
    {
        if (Targets == 1) {
        } else if (Targets >= 2) {
            Damage *= 0.75;
        } else if (Targets < 1)  {
            Damage *= 0;
        }
    }

    void Critical()
    {
        bool isCrit = true;
        double Crit = 1;
        if (isCrit) {
            Crit = 1.5;
        }
    }

    void Rnd()
    {
        double Rand = Random.Range(217, 255) / 255;
    }

    void stab(double STAB)
    {
        if (PokeType == AtkType) {
            STAB = 1.5;
        }
    }

    void isBurn()
    {
        bool isBurn = true;
        double Burn = 1;
        if (isBurn) {
            Burn = 0.5;
        }
    }

    double Mdf(double Crit, double Rand, double STAB, double Burn)
    {
        var Modifier = Targets * Weather * Crit * Rand * STAB * PokeAtk * Burn;
        Dmg(Modifier);
    }

    double Dmg(double Modifier)
    {
        var Damage = ((((((2 * Level) / 5) + 2) * AtkPower * PokeAtk) / 50) + 2) * Modifier;
        return Damage;
    }
}
