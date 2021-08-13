using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBalas : MonoBehaviour
{

    private float vel = 10;

    public float Vel
    {
        get { return vel; }
        set { vel = value; }
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
}
