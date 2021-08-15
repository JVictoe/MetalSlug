using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IteenExemplo : MonoBehaviour
{

    void Start()
    {
        iTween.MoveTo(gameObject, iTween.Hash("x", 0, "y", 10, "z", 0, "time", 2f, "looptype", iTween.LoopType.pingPong, "easetype", iTween.EaseType.easeInOutElastic));
    }


    void Update()
    {
        
    }
}
