using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Deck
{
    public int size;
    public List<Card> cards;

    public Deck(List<Card> cards, int size){
        this.cards = cards;
        this.size = size;
    }

    public override string ToString(){
        string toString = "";
        foreach(Card card in this.cards){
            toString += JsonUtility.ToJson(card);
            toString += "\n";
        }
        return toString;
    }  

}
