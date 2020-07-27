using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] PokemonBase pokemonBase;
    [SerializeField] int level;
    [SerializeField] bool isPlayerUnit;

    public Pokemon Pokemon { get; set; }

    public void Setup()
    {
        Pokemon = new Pokemon(pokemonBase, level);
        if (isPlayerUnit)
        {
            GetComponent<Image>().sprite = Pokemon.PokemonBase.BackSprite;
        } else
        {
            GetComponent<Image>().sprite = Pokemon.PokemonBase.FrontSprite;
        }

    }
}
