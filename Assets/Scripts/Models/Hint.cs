using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SwipeableView;

public class Hint : MonoBehaviour {

    [SerializeField] HintPrefab _hintPrefab = default;
    [SerializeField] Transform _cardRoot = default;


    public void InitializeHint(List<string> hint, int timeInSec){
        HintPrefab go = (HintPrefab)Instantiate (_hintPrefab, _cardRoot);
        string finalText = "";
        foreach(string s in hint){
            finalText += "* " + s + "\n";
        }
        Debug.Log(finalText);
        go.text.text = finalText;
    }

    public HintPrefab GetPrefab(){
        return this._hintPrefab;
    }
}