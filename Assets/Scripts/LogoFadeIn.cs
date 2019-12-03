using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoFadeIn : MonoBehaviour
{
    SpriteRenderer rend;
    public bool isFaded;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Color c = rend.material.color;
        c.a = 0f;
        rend.material.color = c;
    }

    IEnumerator FadeIn(){
        this.isFaded = false;
        Debug.Log("Trying to fadein");
        for(float f = 0.05f;f <= 1; f+=0.05f){
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

      IEnumerator FadeOut(){
        this.isFaded = true;
        Debug.Log("Trying to fadeout");
        for(float f = 1.0f;f <= 0; f-=0.05f){
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void startFading(MovingTextManager.FadeType fadeType){
        if(fadeType == MovingTextManager.FadeType.In){
            StartCoroutine(FadeIn());
        }
        else{
            StartCoroutine(FadeOut());
        }
    }
}
