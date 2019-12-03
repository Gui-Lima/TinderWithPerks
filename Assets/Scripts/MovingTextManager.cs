using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTextManager : MonoBehaviour
{
    public enum FadeType {In, Out};
    public static float text;
    public  float speed;
    public  Vector3 direction;
    private static MovingTextManager instance;
    public GameObject textPrefab;
    public RectTransform canvasTransform;

    public static MovingTextManager Instance{
        get{
            if(instance==null){
                instance = GameObject.FindObjectOfType<MovingTextManager>();
            }
            return instance;
        }
    }

    public void CreateText(Vector3 position){
        GameObject sct = (GameObject) Instantiate(textPrefab, position, Quaternion.identity);
        sct.transform.SetParent(canvasTransform);
        sct.GetComponent<MovingText>().Initialize(speed, direction);
    }

    public void MoveText(string name, Vector3 dir){
        GameObject someText = GameObject.Find (name);
        someText.GetComponent<MovingText>().Initialize(speed, dir);
    }

    public void Initialize(string name){
        GameObject someText = GameObject.Find (name);
        someText.GetComponent<MovingText>().Initialize(0, Vector3.zero);
    }

    public void FadeText(string name, FadeType type){
        GameObject someText = GameObject.Find (name);
        if(type == FadeType.In) someText.GetComponent<MovingText>().Fin();
        if(type == FadeType.Out) someText.GetComponent<MovingText>().Fout();
    }

    public MovingText GetText(string name){
        return GameObject.Find(name).GetComponent<MovingText>();
    }
}
