using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

/**
 *  Frame
 */
 public enum Frame { Common, Rare, Epic, Legendary}; 

/**
 * Card : describe a card
 */
public class Card
{
    // Id of the minion
    public int id;
    // Name of the minion
    public string cardName;
    // Describe of the minion
    public string description;
    // Mana of the minion
    public int mana;
    // Attack of the minion
    public int attack;
    // Heakth of the minion
    public int health;
    // Frame of the minion
    public Frame frame;
    // ArtWork of the minion
    public Sprite artWork;

    public Card(int Id, string CardName, string Description, int Mana, int Attack, int Health, Frame paramFrame, Sprite ArtWork)
    {
        id = Id;
        cardName = CardName;
        description = Description;
        mana = Mana;
        attack = Attack;
        health = Health;
        frame = paramFrame;
        artWork = ArtWork;
    }



}
