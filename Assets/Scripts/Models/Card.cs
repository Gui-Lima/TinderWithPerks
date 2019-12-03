using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Card
{
    public Color color;
    public List<Feature> features;
    public string name;
    public int age;
    public string imageName;
    public Card(Color color, List<Feature> features, string name, int age, string photoName){
        this.color = color;
        this.features = features;
        this.name = name;
        this.age = age;
        this.imageName = photoName;
    }
}
