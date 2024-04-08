using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AttackData : BaseData
{
    public enum CATEGORIES
    {
        PHYSICAL,
        SPECIAL,
        STATUT
    }

    public CATEGORIES category = CATEGORIES.PHYSICAL;
    public TYPES types;
    public int puissance;
    public int precision;

    public AttackData(string label, string caption) : base(label, caption)
    {

    }

    public override void DisplayName()
    {
        Debug.Log("Attaque : " + label);
        base.DisplayName();
    }

}
