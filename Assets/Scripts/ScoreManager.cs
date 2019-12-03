using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;

    private static List<Subscriber> subscribers;

    public static ScoreManager Instance{
        get{
            if(instance==null){
                instance = GameObject.FindObjectOfType<ScoreManager>();
                subscribers = new List<Subscriber>();
            }
            return instance;
        }
    }

    public int CalculateScore(List<Feature> features, List<string> objetivos, string likeOrNope){
        int finalScore = 0;
        foreach(Feature f in features){
            foreach(string s in objetivos){
                Match m = Regex.Match(f.name, s, RegexOptions.IgnoreCase);
                if(m.Success){
                    if(likeOrNope == "like"){
                        finalScore +=2;
                    }
                    else{
                        finalScore--;
                    }
                }
                else{
                    if(likeOrNope == "like"){
                        finalScore --;
                    }
                    else{
                        finalScore++;
                    }
                }
            }
        }
        return finalScore;
    }

    public void AddSub(Subscriber sub){
        if(subscribers == null){
            subscribers = new List<Subscriber>();
        }
        subscribers.Add(sub);
    }

    public void NotifySwipeLeft(){
        foreach(Subscriber sub in subscribers){
            sub.Notify("left");
        }
    }
    public void NotifySwipeRight(){
        foreach(Subscriber sub in subscribers){
            sub.Notify("right");
        }
    }

}
