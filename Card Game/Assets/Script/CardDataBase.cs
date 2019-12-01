using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardBataBase = new List<Card>();

    // Initalize the database
    void Awake()
    {
        cardBataBase.Add(new Card(1, "Wisp", "The weakest minion", 0, 1, 1, Frame.Common, Resources.Load<Sprite>("Image/ArtWork/Wisp")));
        cardBataBase.Add(new Card(2, "Edwin", "The baddest guy", 3, 3, 3, Frame.Lengendary, Resources.Load<Sprite>("Image/ArtWork/Edwin")));
        cardBataBase.Add(new Card(3, "Tirion", "The light shall will burn", 8, 6, 6, Frame.Lengendary, Resources.Load<Sprite>("Image/ArtWork/Tirion")));
    }
    
}
