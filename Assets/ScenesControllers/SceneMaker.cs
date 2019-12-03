using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class SceneMaker
{
    public static string currentPath;
    public static string currentJSON;


    public static void setLevelWindows(string filename){
        Debug.Log(Application.dataPath);
        string filePath = Path.Combine (Application.dataPath,"Boards", filename);

        if (File.Exists (filePath)) {
            byte[] jsonBytes = File.ReadAllBytes (filePath);
            currentJSON = Encoding.ASCII.GetString (jsonBytes);
        } else {
            Debug.Log ("No such file");
        } 
    }
    public static void setLevelAndroid(string filename){
        string filePath = Path.Combine (Application.persistentDataPath, filename);

        if (File.Exists (filePath)) {
            byte[] jsonBytes = File.ReadAllBytes (filePath);
            currentJSON = Encoding.ASCII.GetString (jsonBytes);
        } else {
            Debug.Log ("No such file");
        }   
    }

    public static Deck getCurrentdeck(){
        Board board = JsonUtility.FromJson<Board>(currentJSON);
        return board.deck;
    }

}
