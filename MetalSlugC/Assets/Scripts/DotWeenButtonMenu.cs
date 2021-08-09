using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DotWeenButtonMenu : MonoBehaviour
{

    [SerializeField] private Button btn = default;
    [SerializeField] private RectTransform btnRect = default;
    [SerializeField] private Text txtButton = default;
    [SerializeField] private int duract = default;
    [SerializeField] private float pos = default;

    void Start()
    {
        MoveCima();
    }

    void Update()
    {
        
    }

    void MoveCima()
    {
        btn.enabled = true;
        btn.image.enabled = true;
        txtButton.enabled = true;
        btn.image.DOFade(1, 3);
        txtButton.DOFade(1, 3);

        //Mover
        btnRect.DOAnchorPosY(pos, duract, true);
    }

}
