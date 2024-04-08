using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{
    public PokemonController pokemon;
    public PokemonController pokemonBOT;

    public static PokemonController currentPokemon;

    void Start()
    {
        pokemon.Init(DatabaseManager.GetInstance()._database.datas[0]);
        pokemonBOT.Init(DatabaseManager.GetInstance()._database.datas[1]);

        currentPokemon = pokemon;
    }

    public void StartBattle()
    {
        Debug.Log("Le combat Pokémon démarre !");
    }


}
