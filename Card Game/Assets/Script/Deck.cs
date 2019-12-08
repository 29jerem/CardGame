using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

// Deck contains card
public class Deck
{
    public List<Card> listeCard = new List<Card>();
    public const int sizeDeck = 30;

    public Deck()
    {
        listeCard = new List<Card>();
    }

    public bool AddACard(Card card)
    {
        if(listeCard.Count < 30)
        {
            int nbSameIdCard = SearchIdCard(card.id);
            if(nbSameIdCard < 2 && card.frame != Frame.Legendary)
            {
                listeCard.Add(card);
                return true;
            } else if (nbSameIdCard < 1 && card.frame == Frame.Legendary)
            {
                listeCard.Add(card);
                return true;
            }
        }
        return false;
    }

    public int SearchIdCard(int idCard)
    {
        int nbSameIdCard = 0;
        foreach(Card card in listeCard)
        {
            if(card.id == idCard)
            {
                nbSameIdCard++;
            }
        }
        return nbSameIdCard;
    }
}
