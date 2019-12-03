using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DictValues {

    public static Feature[] features = {
        new Feature("Loves Joias"),
        new Feature("Hates Joias")
    };
    public static string[] names = {"Dodie"
,"Shaunna"
,"Garret"
,"Lynn"
,"Gilberto"
,"Estela"
,"Kindra"
,"Tabitha"
,"Verena"
,"Jefferey"
,"Genny"
,"Alease"
,"Kena"
,"Nelida"
,"Ping"
,"Clorinda"
,"Catalina"
,"Buddy"
,"Jame"
,"Tu"
,"Deja"
,"Hershel"
,"Ileana"
,"Elma"
,"Maida"
,"Tia"
,"Cassie"
,"Veronica"
,"Muriel"
,"Shoshana"
,"Markus"
,"Rueben"
,"Jacqulyn"
,"Love"
,"Barbara"
,"Cristen"
,"Kyra"
,"Wenona"
,"Kathlyn"
,"Deedee"
,"Millicent"
,"Diedre"
,"Matthew"
,"Sung"
,"Lakesha"
,"Trinity"
,"Sheron"
,"Neva"
,"Genia"
,"Reiko"
,"Gandalf"};

  public static string getRandomName(){
        var random = new System.Random();
        int index = random.Next(0, names.Length);
        return names[index];
    }

}