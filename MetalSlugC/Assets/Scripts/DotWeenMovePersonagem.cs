using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DotWeenMovePersonagem : MonoBehaviour
{

    [SerializeField] private RectTransform imgRect = default;
    [SerializeField] private Image img = default;
    [SerializeField] private float pos = default;
    [SerializeField] private int durac = default;

    void Start()
    {
        StartCoroutine(nameof(MoveX));
    }

    IEnumerator MoveX()
    {
        yield return new WaitForSeconds(2);
        img.enabled = true;
        imgRect.DOAnchorPosX(pos, durac, true); 
        img.DOFade(1, 3);
    }

}
