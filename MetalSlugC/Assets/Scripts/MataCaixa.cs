using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MataCaixa : MonoBehaviour
{
    [SerializeField] private float time = default;
    void Start()
    {
        StartCoroutine(nameof(DestroiObj));
    }

    
    void DestroiObj()
    {
        Destroy(gameObject, time);
    }
}
