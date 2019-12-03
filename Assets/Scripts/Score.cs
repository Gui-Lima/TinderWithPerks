using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public Text text;
    public void setScore(int score){
        this.text.text = score.ToString();
    }

    public int getScore(){
        int numVal = Int32.Parse(this.text.text);
        return numVal;
    }

    public void addScore(int score){
        int numVal = Int32.Parse(this.text.text);
        int newScore = numVal + score;
        this.text.text = newScore.ToString();
    }
}
