using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{

    // Test de creation d'une carte
    public GameObject cardPrefab;
    public int increment;

    // Update is called once per frame
    void Update()
    {

        // Event when user use Space
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Create a prefab Card
            GameObject carte = Instantiate(cardPrefab) as GameObject;

            // Position the card
            GameObject canvas = GameObject.Find("MyDeck");
            carte.transform.SetParent(canvas.transform);
            carte.transform.position = new Vector3(transform.position.x, transform.position.y, 0);

            // Initialize the card
            CardDisplay.InitializeCard(0, false, carte);            
        }
    }
}
