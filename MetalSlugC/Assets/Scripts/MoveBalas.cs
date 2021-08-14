using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBalas : MonoBehaviour
{

    private float vel = 10;
    //[SerializeField] private Transform ll;
    //[SerializeField] private Transform lr;

    public float Vel
    {
        get { return vel; }
        set { vel = value; }
    }

    private void Start()
    {
        //ll = GameObject.FindWithTag("limiteL").GetComponent<Transform>();
        //lr = GameObject.FindWithTag("limiteR").GetComponent<Transform>();
    }

    void Move()
    {
        Vector3 aux = transform.position;
        aux.x += vel * Time.deltaTime;
        transform.position = aux;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("limiteR") || collision.gameObject.CompareTag("limiteL"))
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
