using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokeball : MonoBehaviour
{
    // The Pokemon data file.
    public PokemonData data;

    // The Pokemon sprite that is a child of this object.
    public SpriteRenderer pokemonSprite;

    // Start is called before the first frame update
    void Start()
    {
        Hide();
    }

    // public method named show
    // displays the pokemon sprite
    public void Show()
    {
        pokemonSprite.gameObject.SetActive(true);
    }

    // public method named hide
    // hides the pokemon sprite
    public void Hide()
    {
        pokemonSprite.gameObject.SetActive(false);
    }
}
