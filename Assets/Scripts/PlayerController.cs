using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;
    Rigidbody2D rb;

    //contagem regressiva para vencer
    public float timeToWin;

    public Text timeToWinText;
    public Text gameOverText;
    //public Text winText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeToWin = Mathf.Clamp(timeToWin - Time.deltaTime, 0, 60);
        timeToWinText.text = "Time Left to Jump: " + Mathf.CeilToInt(timeToWin);

        if (timeToWin <= 0 && !gameOverText.gameObject.activeSelf)
        {
            gameOverText.text = "You Escaped This Sector!";
            gameOverText.gameObject.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        //Controlar a nave com os Botoes W e S
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = Vector2.up * speed;
        } 
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = Vector2.down * speed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    private void LateUpdate()
    {
        //impede que a nave saia da tela
        float topBound = 5.3f;
        float bottonBound = -5.3f;

        float clampedY = Mathf.Clamp(transform.localPosition.y, bottonBound, topBound);
        Vector3 curPos = transform.localPosition;
        transform.localPosition = new Vector3(curPos.x, clampedY, curPos.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Se a nave colidir com um inimigo/obstaculo, destroi os 2
        if (collision.CompareTag("Enemy") && !gameOverText.gameObject.activeSelf)
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            gameOverText.text = "You Died!";
            gameOverText.gameObject.SetActive(true);
        }
    }
}
