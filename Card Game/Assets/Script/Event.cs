using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{

    // Test de creation d'une carte
    public GameObject cardPrefab;

    // Update is called once per frame
    void Update()
    {

        // Event when user use Space
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Create a prefab Card
            GameObject card = Instantiate(cardPrefab) as GameObject;

            PanelDisplayDeck.CreateACardDisplay(card, 1);
        }
    }
}
