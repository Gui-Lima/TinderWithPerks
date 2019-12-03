using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLogoFadeIn : MonoBehaviour
{
  
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "InvisibleBoxCollider"){
            MovingTextManager.Instance.FadeText("InitialCutsceneText", MovingTextManager.FadeType.Out);
            GameObject go = GameObject.Find("logo_main");
            LogoFadeIn other = (LogoFadeIn) go.GetComponent(typeof(LogoFadeIn));
            other.startFading(MovingTextManager.FadeType.In);
        }

        MovingTextManager.Instance.FadeText("StartGameText", MovingTextManager.FadeType.In);
    }

}
