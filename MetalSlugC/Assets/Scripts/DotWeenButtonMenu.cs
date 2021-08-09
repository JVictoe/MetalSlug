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
    //public int id;

    [SerializeField] private float startPosX = default;


    private void Awake()
    {
        //btn.onClick.AddListener(delegate { AvancaCena(id); });
    }

    void Start()
    {
        startPosX = transform.position.y;
        MoveCima();
    }

    //void AvancaCena(int id)
    //{
    //    if (id == 1) StartCoroutine(MoveBaixo(0.1f));
    //    else if (id == 2 || id == 3) MoveCima();
    //}

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(MoveBaixo(0.1f));
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            MoveCima();
        }
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

    IEnumerator MoveBaixo(float temp)
    {
        while(btn.image.color.a > 0.01f)
        {
            yield return new WaitForSeconds(temp);
            btn.image.DOFade(0, 1);
            txtButton.DOFade(0, 1);

            //Mover
            btnRect.DOMoveY(startPosX, duract, true);
        }


        btn.enabled = false;
        btn.image.enabled = false;
        txtButton.enabled = false;
    }

}
