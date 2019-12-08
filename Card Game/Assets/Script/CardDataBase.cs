using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardDB = new List<Card>();

    // Initalize the database
    void Awake()
    {
        cardDB.Add(new Card(1, "Wisp", "The weakest minion", 0, 1, 1, Frame.Common, Resources.Load<Sprite>("Image/ArtWork/Wisp")));
        cardDB.Add(new Card(2, "Edwin", "The baddest guy", 3, 3, 3, Frame.Legendary, Resources.Load<Sprite>("Image/ArtWork/Edwin")));
        cardDB.Add(new Card(3, "Tirion", "The light shall will burn", 8, 6, 6, Frame.Legendary, Resources.Load<Sprite>("Image/ArtWork/Tirion")));
    }
    
}
