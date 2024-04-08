using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class DatabaseManager : MonoBehaviour
{
    private static DatabaseManager instance;

    public PokemonDatabase _database;
    public AttackDatabase _attackDatabase;

    public static DatabaseManager GetInstance()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<DatabaseManager>();
            if (instance == null)
            {
                Debug.LogError("DatabaseManager instance not found in the scene!");
            }
        }
        return instance;
    }

    public AttackData GetAttackData(string label)
    {
        return _attackDatabase?.datas.Find(x => x.label.ToLower().Contains(label.ToLower()));
    }

    public PokemonData GetData(int id)
    {
        return _database.datas[id];
    }

    public int GetTotalPokemonCount()
    {
        return _database.datas.Count;
    }

    private void Start()
    {
        _database.InitData();
        _database.CreateDataNoctali();
        _database.CreateDataMentali();
        _database.CreateDataPhyllali();
        _database.CreateDataGivrali();
        _database.CreateDataNymphali();
        _database.CreateDataAquali();
        _database.CreateDataVoltali();
        _database.CreateDataPyroli();
        _database.CreateDataEvoli();
        _database.CreateDataPtera();
    }
}
