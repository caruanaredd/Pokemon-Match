using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokeball : MonoBehaviour
{
    public GameObject pokemonSprite;

    // Start is called before the first frame update
    void Start()
    {
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public method named show
    // displays the pokemon sprite
    public void Show()
    {
        pokemonSprite.SetActive(true);
    }

    // public method named hide
    // hides the pokemon sprite
    public void Hide()
    {
        pokemonSprite.SetActive(false);
    }
}
