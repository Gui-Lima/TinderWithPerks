using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingText : MonoBehaviour
{
    private float speed;
    private Vector3 direction;
    [SerializeField]
    private float fadeTime;

    public bool isFadingOut = false;

    public bool isFadingIn = false;

    // Update is called once per frame
    void Update(){
        float translation = this.speed * Time.deltaTime; 
        transform.Translate(this.direction * translation);    
    }

    public void Initialize(float speed, Vector3 direction, float fadeTime = 2){
        this.speed = speed;
        this.direction = direction;
        this.fadeTime = fadeTime;
    }

    public void Fout(){
        this.isFadingOut = true;
        StartCoroutine(FadeOut());
    }

    public void Fin(){
        this.isFadingIn = true;
        StartCoroutine(FadeIn());
    }

    private IEnumerator FadeOut(){
        float startAlpha = GetComponent<Text>().color.a;
        float rate = 1.0f/fadeTime;
        float progress = 0.0f;
        while(progress < 1.0){
            Color tempColor = GetComponent<Text>().color;
            GetComponent<Text>().color = new Color(tempColor.r, tempColor.g, tempColor.b, Mathf.Lerp(startAlpha, 0, progress));
            progress += rate * Time.deltaTime;
            yield return null;
        }
        this.isFadingOut = false;
    }

    public IEnumerator FadeIn(){
        float rate = 1.0f/fadeTime;
        float progress = 1.0f;
        while(progress > 0.0){
            Color tempColor = GetComponent<Text>().color;
            GetComponent<Text>().color = new Color(tempColor.r, tempColor.g, tempColor.b, Mathf.Lerp(0, 255, progress));
            progress -= rate * Time.deltaTime;
            yield return null;
        }
        this.isFadingIn = false;
    }
}
