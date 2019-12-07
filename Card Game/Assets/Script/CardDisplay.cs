using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    public const string nameOfTheCard = "Name";
    public const string descriptionOfTheCard = "Description";
    public const string manaOfTheCard = "Mana";
    public const string attackOfTheCard = "Attack";
    public const string healthOfTheCard = "Health";
    public const string artworkmaskOfTheCard = "ArtWorkMask";
    public const string artworkOfTheCard = "ArtWork";
    public const string backOfTheCard = "Back";

    // Refresh the card with the id and if is the back of the card is present
    public static void InitializeCard(int idCardDB, bool isBack, GameObject card)
    {
        // Give the information of the card
        Card cardDataBase = CardDataBase.cardDB[idCardDB];
        DisplayBack(card, isBack);
        ChangeTextName(card, cardDataBase.cardName);
        ChangeTextDescription(card, cardDataBase.description);
        ChangeTextMana(card, cardDataBase.mana);
        ChangeTextAttack(card, cardDataBase.attack);
        ChangeTextHealth(card, cardDataBase.health);
        ChangeArtWork(card, cardDataBase.artWork);
    }

    // Set the text of name
    public static bool ChangeTextName(GameObject card, string textToChange)
    {
        return ChangeText(card, textToChange, CardDisplay.nameOfTheCard);
    }

    // Set the text of the description
    public static bool ChangeTextDescription(GameObject card, string textToChange)
    {
        return ChangeText(card, textToChange, CardDisplay.descriptionOfTheCard);
    }

    // Set the text of mana
    public static bool ChangeTextMana(GameObject card, int textToChange)
    {
        return ChangeText(card, textToChange.ToString(), CardDisplay.manaOfTheCard);
    }

    // Set the text of Attack
    public static bool ChangeTextAttack(GameObject card, int textToChange)
    {
        return ChangeText(card, textToChange.ToString(), CardDisplay.attackOfTheCard);
    }

    // Set the text of Health
    public static bool ChangeTextHealth(GameObject card, int textToChange)
    {
        return ChangeText(card, textToChange.ToString(), CardDisplay.healthOfTheCard);
    }

    // Set the text of a property of a card
    public static bool ChangeText(GameObject card, string textToChange, string textDescription)
    {
        Transform textTransform = card.transform.Find(textDescription);
        if(textTransform != null)
        {
            textTransform.gameObject.GetComponent<UnityEngine.UI.Text>().text = textToChange;
            return true;
        }
        return false;
    }

    // Set the image of ArtWork
    public static bool ChangeArtWork(GameObject card, Sprite artWork)
    {
        Transform artWorkMaskTransform= card.transform.Find(CardDisplay.artworkmaskOfTheCard);
        if(artWorkMaskTransform != null)
        {
            Transform artWorkTransform = artWorkMaskTransform.Find(CardDisplay.artworkOfTheCard);
            if(artWorkTransform  != null)
            {
                artWorkTransform.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = artWork;
                return true;
            }
        }
        return false;
    }

    // Active or not the back of the card
    public static bool DisplayBack(GameObject card, bool back)
    {
        Transform cardBack = card.transform.Find(CardDisplay.backOfTheCard);
        if(cardBack != null)
        {
            if(back)
            {
                cardBack.gameObject.SetActive(true);
            }
            else
            {
                cardBack.gameObject.SetActive(false);
            }
            return true;
        }
        return false;
    }
}
