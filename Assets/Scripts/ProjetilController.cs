using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilController : MonoBehaviour
{
    public float timeout = 5;
    public float speed;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //destroi o projetil apos 10 segundos
        Destroy(this.gameObject, timeout);
    }

    private void FixedUpdate()
    {
        //velocidade do projetil
        rb.velocity = Vector2.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Se o projetil colidir com um inimigo/obstaculo, destroi os 2
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
