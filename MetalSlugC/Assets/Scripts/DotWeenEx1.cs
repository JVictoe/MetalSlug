using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DotWeenEx1 : MonoBehaviour
{

    [SerializeField] private RectTransform imagemRect = default;
    [SerializeField] private Image imagemSr = default;

    [SerializeField] private float velf = default;
    [SerializeField] private float vels = default;
    [SerializeField] private bool fade = default;
    [SerializeField] private bool scale = default;

    void Start()
    {

    }

    private void Update()
    {
        AnimacaoScala(velf, vels, fade, scale);
    }

    void AnimacaoScala(float velf, float vels, bool fade, bool scale)
    {
        if(scale)
        {
            if (imagemRect.localScale.x == 1)
            {
                imagemRect.DOScale(new Vector3(1.2f, 1.2f, 1.2f), vels);
            }
            else if (imagemRect.localScale.x == 1.2f)
            {
                imagemRect.DOScale(new Vector3(1f, 1f, 1f), vels);
            }
        }
        
        if (fade)
        {
            if (imagemSr.color.a == 1)
            {
                imagemSr.DOFade(0, velf);
            }
            else if (imagemSr.color.a == 0)
            {
                imagemSr.DOFade(1, velf);
            }
        }

    }
}
