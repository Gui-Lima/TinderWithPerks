using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Board
{
    public string name;
    public Deck deck;
    public Board(string name, Deck deck){
       this.name = name;
       this.deck = deck;
    }

    public override string ToString(){
        string toString = this.name + "\n";
        foreach(Card card in this.deck.cards){
            toString += JsonUtility.ToJson(card);
            toString += "\n";
        }
        return toString;
    } 
}
