using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DotWeenRot : MonoBehaviour
{

    [SerializeField] private Image imgRot = default;
    [SerializeField] private bool liberaRot = true;

    void Start()
    {
        StartCoroutine(nameof(Rotaciona));
    }

    IEnumerator Rotaciona()
    {
        while(liberaRot)
        {
            int rand = Random.Range(1, 5);
            imgRot.rectTransform.DORotate(new Vector3(0,0,rand * 10), 2, RotateMode.Fast);
            yield return new WaitForSeconds(2);
            imgRot.rectTransform.DORotate(new Vector3(0, 0, rand * 10), 2, RotateMode.Fast);
        }
    }

}
