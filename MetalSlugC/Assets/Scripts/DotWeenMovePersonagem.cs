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
    [SerializeField] private float startPosX = default;

    void Start()
    {
        startPosX = transform.position.x;
        StartCoroutine(MoveX(1));
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(MoveXInvers(0.5f));
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            StartCoroutine(MoveX(1));
        }
    }

    IEnumerator MoveX(float temp)
    {
        yield return new WaitForSeconds(temp);
        img.enabled = true;
        imgRect.DOAnchorPosX(pos, durac, true); 
        img.DOFade(1, 3);
    }

    IEnumerator MoveXInvers(float temp)
    {
        while(img.color.a > 0.01f)
        {
            yield return new WaitForSeconds(temp);
            imgRect.DOMoveX(startPosX, durac, true);
            img.DOFade(0, 0.5f);
        }

        img.enabled = false;
    }

}
