using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISceneController{
    IEnumerator WaitXSeconds(int seconds);

    void win();
    void lose();
}
