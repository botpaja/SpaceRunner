using UnityEngine;

public class Enemy1Controller : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    float timeOut = 5;

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
