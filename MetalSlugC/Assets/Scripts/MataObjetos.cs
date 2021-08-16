using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MataObjetos : MonoBehaviour
{
    [SerializeField] private Animator anim = default;

    void Start()
    {
        Invoke(nameof(DestroiObj), anim.GetCurrentAnimatorStateInfo(0).length);
    }

    
    void DestroiObj()
    {
        Destroy(gameObject);
    }
}
