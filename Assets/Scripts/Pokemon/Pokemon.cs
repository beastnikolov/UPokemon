using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    public PokemonBase PokemonBase { get; set; }
    public int PokemonLevel { get; set; }

    public int HP { get; set; }

    public List<Move> Moves { get; set; }

    public Pokemon(PokemonBase pokemonBase, int pokemonLevel)
    {
        this.PokemonBase = pokemonBase;
        this.PokemonLevel = pokemonLevel;
        HP = MaxHP;

        Moves = new List<Move>();
        foreach (var move in pokemonBase.LearnableMoves)
        {
            if (move.Level <= pokemonLevel)
            {
                Moves.Add(new Move(move.Base));
            }

            if (Moves.Count >= 4)
            {
                break;
            }
        }
    }

    public int MaxHP
    {
        get { return Mathf.FloorToInt((PokemonBase.MaxHP * PokemonLevel) / 100f) + 10; }
    }

    public int Attack
    {
        get { return Mathf.FloorToInt((PokemonBase.Attack * PokemonLevel) / 100f) + 5; }
    }

    public int Defense
    {
        get { return Mathf.FloorToInt((PokemonBase.Defense * PokemonLevel) / 100f) + 5; }
    }

    public int SpAttack
    {
        get { return Mathf.FloorToInt((PokemonBase.SpAttack * PokemonLevel) / 100f) + 5; }
    }

    public int SpDefense
    {
        get { return Mathf.FloorToInt((PokemonBase.SpDefense * PokemonLevel) / 100f) + 5; }
    }

    public int Speed
    {
        get { return Mathf.FloorToInt((PokemonBase.Speed * PokemonLevel) / 100f) + 5; }
    }
}
