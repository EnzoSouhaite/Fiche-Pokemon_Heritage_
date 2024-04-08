using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PokemonData : BaseData
{
    [Serializable]
    public struct Stats
    {
        public int pv;
        public int attack;
        public int defense;
        public int atkSpe;
        public int defSpe;
        public int speed;

        public Stats(int pv, int attack, int defense, int atkSpe, int defSpe, int speed)
        {
            this.pv = pv;
            this.attack = attack;
            this.defense = defense;
            this.atkSpe = atkSpe;
            this.defSpe = defSpe;
            this.speed = speed;
        }

        public Stats(Stats statsBase, int coeff)
        {
            this.pv = statsBase.pv * coeff;
            attack = statsBase.attack * coeff;
            defense = statsBase.defense * coeff;
            atkSpe = statsBase.atkSpe * coeff;
            defSpe = statsBase.defSpe * coeff;
            speed = statsBase.speed * coeff;
        }
    }

    [Serializable]
    public struct AttackWrapper
    {
        public string label;
        public int level;

        public AttackWrapper(string label, int level)
        {
            this.label = label;
            this.level = level;
        }
    }

    public string name;
    public int number;
    public float size;
    public float weight;
    public string type;
    public Sprite icon;
    public List<TYPES> types;
    public List<AttackWrapper> attacks = new();

    public Stats statsBase;

    public PokemonData(string label, int number, float size, float weight, string type, Sprite icon, string caption, Stats stats = default, params TYPES[] types)
        : base(label, caption)
    {
        this.types = new List<TYPES>(types);
        this.number = number;
        this.size = size;
        this.weight = weight;
        this.type = type;
        this.icon = icon;

        this.statsBase = stats;
    }

}