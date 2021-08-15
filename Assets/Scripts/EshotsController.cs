using UnityEngine;

public class EshotsController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public float timeOut = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Destroy o projetil inimigo depois do tempo
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
