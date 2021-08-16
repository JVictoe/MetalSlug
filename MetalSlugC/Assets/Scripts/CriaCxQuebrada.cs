using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaCxQuebrada : MonoBehaviour
{

    [SerializeField] private GameObject caixaQuebrada = default;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("balas"))
        {
            Instantiate(caixaQuebrada, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
