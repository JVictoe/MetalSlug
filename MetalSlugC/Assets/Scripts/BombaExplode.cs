using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaExplode : MonoBehaviour
{

    [SerializeField] private bool colidiu = false;
    [SerializeField] private float raio = default;
    [SerializeField] private LayerMask layer = default;
    [SerializeField] private GameObject animBomba = default;

    void Start()
    {
        
    }

    void Update()
    {
        if(colidiu)
        {
            Instantiate(animBomba, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        colidiu = Physics2D.OverlapCircle(transform.position, raio, layer);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, raio);
    }
}
