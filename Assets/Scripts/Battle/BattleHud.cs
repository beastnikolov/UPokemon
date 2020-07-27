using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHud : MonoBehaviour
{

    [SerializeField] Text nameText;
    [SerializeField] Text levelText;
    [SerializeField] HPBar hpBar;

    public void SetHudData(Pokemon pokemon)
    {
        nameText.text = pokemon.PokemonBase.Name;
        levelText.text = "Lvl " + pokemon.PokemonLevel;
        //Debug.Log("Pokemon HP normalized:" + (float)pokemon.HP / pokemon.MaxHP);
        //Debug.Log("Pokemon HP:" + pokemon.HP + "/" + pokemon.MaxHP);
        hpBar.SetHP((float)pokemon.HP / pokemon.MaxHP);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
