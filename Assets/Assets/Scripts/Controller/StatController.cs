using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatController : MonoBehaviour
{
    [Header("IMAGE")]
    [SerializeField] private Image _imgPv;
    [SerializeField] private Image _imgAtk;
    [SerializeField] private Image _imgDef;
    [SerializeField] private Image _imgAtkSpe;
    [SerializeField] private Image _imgDefSpe;
    [SerializeField] private Image _imgSpeed;
    [Header("TEXT")]
    [SerializeField] private Text _txtPv;
    [SerializeField] private Text _txtAtk;
    [SerializeField] private Text _txtDef;
    [SerializeField] private Text _txtAtkSpe;
    [SerializeField] private Text _txtDefSpe;
    [SerializeField] private Text _txtSpeed;

    public void RefreshUI(PokemonData.Stats stats)
    {
        _imgPv.fillAmount        = stats.pv;
        _imgAtk.fillAmount       = stats.attack;
        _imgDef.fillAmount       = stats.defense;
        _imgAtkSpe.fillAmount    = stats.atkSpe;
        _imgDefSpe.fillAmount    = stats.defSpe;
        _imgSpeed.fillAmount     = stats.speed;

        _txtPv.text         = $"Pv [{stats.pv}]";
        _txtAtk.text        = $"Atk[{stats.attack}]";
        _txtDef.text        = $"Def[{stats.defense}]";
        _txtAtkSpe.text     = $"AtkS[{stats.atkSpe}]";
        _txtDefSpe.text     = $"DefS[{stats.defSpe}]";
        _txtSpeed.text      = $"Spd[{stats.speed}]";
    }
}
