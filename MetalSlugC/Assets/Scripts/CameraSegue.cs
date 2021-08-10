using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegue : MonoBehaviour
{
    [SerializeField] private GameObject player = default;
    public float camVel = 0.25f;
    private bool segueHeroi;
    public Vector3 ultimoAlvoPos;
    public Vector3 velAtual;

    void Start()
    {
        segueHeroi = true;
        ultimoAlvoPos = player.transform.position;
    }

    private void FixedUpdate()
    {
        if(segueHeroi)
        {
            if(player.transform.position.x > transform.position.x)
            {
                Vector3 novaCamPos = Vector3.SmoothDamp(transform.position, player.transform.position, ref velAtual, camVel);
                transform.position = new Vector3(novaCamPos.x, novaCamPos.y, transform.position.z);

                ultimoAlvoPos = player.transform.position;
            }
        }
    }
}
