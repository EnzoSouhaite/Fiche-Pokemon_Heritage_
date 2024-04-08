using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackSlotController : MonoBehaviour
{

    [SerializeField] private Text _txtLabel;
    [SerializeField] private Button _Atk;

    private AttackData _data;


    private void Awake()
    {
        _Atk = GetComponent<Button>();
        _txtLabel = GetComponentInChildren<Text>();

        _Atk.onClick.AddListener(() => DisplayAttack());
    }
    public void Init(string label)
    {
        _data = DatabaseManager.GetInstance().GetAttackData(label);

        _txtLabel.text = _data.label;
    }

    private void DisplayAttack()
    {
        Debug.Log($"{BattleController.currentPokemon._data.label} utilise {_txtLabel.text}");
    }
}
