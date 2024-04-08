using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PokemonController : MonoBehaviour
{

    [SerializeField] private Text _txtLabel;
    [SerializeField] private Image _imgIcone;

    [Header("PV")]
    [SerializeField] private Image _imgPv;
    [SerializeField] private Text _txtPv;

    [SerializeField] private List<AttackSlotController> _AtkSlot = new();

    public PokemonData _data { get; private set; }
    private int _currentLife;

    public void Init(PokemonData data)
    {
        _data = data;
        _txtLabel.text = _data.label;
        _imgIcone.sprite = _data.icon;

        _currentLife = data.statsBase.pv;

        foreach(AttackSlotController slot in _AtkSlot)
        {
            var id = _AtkSlot.IndexOf(slot);
            slot.Init(data.attacks[id].label);
        }

        RefreshUI();
    }

    private void RefreshUI()
    {
        _txtPv.text = $"{_currentLife:00}/ {_data.statsBase.pv:00}";
    }

    private void InitAtk()
    {

    }
}
