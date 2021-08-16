using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItweenFade : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(nameof(EfeitoAlpha));
    }

    
    IEnumerator EfeitoAlpha()
    {
        yield return new WaitForSeconds(1);
        iTween.FadeTo(gameObject, iTween.Hash("alpha", 0, "delay", 0.01f, "time", 0.2f, "looptype", iTween.LoopType.pingPong, "easetype", iTween.EaseType.easeInElastic));
    }
}
