using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroiControle : MonoBehaviour
{

    [SerializeField] private float puloMenorY = 0.6f;
    [SerializeField] private float puloMaiorY = 2f;
    [SerializeField] private Rigidbody2D rb = default;
    [SerializeField] private bool face = true;
    [Range(1, 20)] public float maxSpeed = 5f;
    [SerializeField] private float move = default;

    public bool noChao;
    [SerializeField] private Transform noChaoCheck = default;
    public float noChaoRaio = 0.02f;
    [SerializeField] private LayerMask oQueEChao = default;
    [Range(1, 20)] public float jumpForce = 5f;

    [SerializeField] private Animator animH = default;

    [SerializeField] private GameObject bala = default;
    [SerializeField] private GameObject canoArma = default;
    [SerializeField] private GameObject bomba = default;
    [SerializeField] private GameObject localBomba = default;
    
    void Start()
    {
        
    }

    void Update()
    {
        //Pular
        if(noChao && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        //Andar
        if(noChao)
        {
            move = Input.GetAxis("Horizontal");
            animH.SetFloat("X", Mathf.Abs(move));
        }

        //Tiros
        if(noChao && Input.GetKeyDown(KeyCode.Mouse0))
        {
            animH.SetTrigger("Tiro");
            GameObject balaInst = Instantiate(bala, canoArma.transform.position, Quaternion.identity);
            balaInst.GetComponent<MoveBalas>().Vel *= transform.localScale.x;
        }

        //Bate
        if (noChao && Input.GetKeyDown(KeyCode.E))
        {
            animH.SetTrigger("bomba");

            GameObject bombaInst = Instantiate(bomba, localBomba.transform.position, Quaternion.identity);
            bombaInst.GetComponent<Rigidbody2D>().AddForce(new Vector2(2f * transform.localScale.x, 3f), ForceMode2D.Impulse);
        }

        //Pular
        animH.SetFloat("Y", rb.velocity.y);
        animH.SetBool("chao", noChao);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(noChaoCheck.position, noChaoRaio);
    }

    private void FixedUpdate()
    {
        noChao = Physics2D.OverlapCircle(noChaoCheck.position, noChaoRaio, oQueEChao);

        if(rb.velocity.y < 0)
        {
            rb.gravityScale = puloMenorY;
        }
        else if(rb.velocity.y > 0 && !Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale = puloMaiorY;
        }
        else
        {
            rb.gravityScale = 1;
        }

        if(noChao)
        {
            rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);
        }

        if(move > 0 && !face)
        {
            Flip();
        }
        else if(move < 0 && face)
        {
            Flip();
        }
    }

    void Flip()
    {
        face = !face;
        Vector3 tempScale = transform.localScale;
        tempScale.x *= -1;
        transform.localScale = tempScale;
    }

}
