using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDisplayDeck : MonoBehaviour
{
    public static List<GameObject> listeCardDeckGameObject = new List<GameObject>();

    public static void CreateACardDisplay(GameObject cardGameObject, int idCardDB)
    {
        GameObject myDeckGameObject = GameObject.Find("MyDeck");
        cardGameObject.transform.SetParent(myDeckGameObject.transform);

        // Initialize the card
        CardDisplay.InitializeCard(idCardDB, false, cardGameObject);

        // Add to the deck
        listeCardDeckGameObject.Add(cardGameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            SeeInformations();
        } 
        else if(Input.GetKeyDown(KeyCode.Keypad2))
        {
            RemoveCard();
        }
    }

    public void SeeInformations()
    {
        Debug.Log("Number of card in the deck : " + listeCardDeckGameObject.Count);
    }

    public void RemoveCard()
    {
        GameObject objectToDestroy = listeCardDeckGameObject[0];
        listeCardDeckGameObject.Remove(objectToDestroy);
        //Destroy(objectToDestroy);
        PanelDisplayHand.CreateACardDisplay(objectToDestroy, 1);
    }

}
