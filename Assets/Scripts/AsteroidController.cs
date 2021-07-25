using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    float timeOut = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Destroy o asteroid depois do tempo
        Destroy(this.gameObject, timeOut);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //velocidade do projetil
        rb.velocity = Vector2.left * speed;
    }
}
