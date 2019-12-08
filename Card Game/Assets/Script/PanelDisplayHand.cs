using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDisplayHand : MonoBehaviour
{
    public static List<GameObject> listeCardHandGameObject = new List<GameObject>();

    public static void CreateACardDisplay(GameObject cardGameObject, int idCardDB)
    {
        GameObject myHandGameObject = GameObject.Find("MyHand");
        cardGameObject.transform.SetParent(myHandGameObject.transform);

        // Initialize the card
        CardDisplay.InitializeCard(idCardDB, false, cardGameObject);

        // Add to the deck
        listeCardHandGameObject.Add(cardGameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            SeeInformations();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            RemoveCard();
        }
    }

    public void SeeInformations()
    {
        Debug.Log("Number of card in the deck : " + listeCardHandGameObject.Count);
    }

    public void RemoveCard()
    {
        GameObject objectToDestroy = listeCardHandGameObject[0];
        listeCardHandGameObject.Remove(objectToDestroy);
        Destroy(objectToDestroy);

    }
}
