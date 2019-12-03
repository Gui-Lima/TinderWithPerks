using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        MovingTextManager.Instance.MoveText("InitialCutsceneText", Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0)) {
            GameObject go = GameObject.Find("logo_main");
            LogoFadeIn other = (LogoFadeIn) go.GetComponent(typeof(LogoFadeIn));
            if (!other.isFaded){
                SceneManager.LoadScene("Scene_Tutorial");
            } 
        }
    }
}
