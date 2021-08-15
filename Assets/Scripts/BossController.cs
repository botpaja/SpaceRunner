using UnityEngine;
using UnityEngine.UI;

public class BossController : MonoBehaviour
{
    int hitPoints = 40;
    public Text BossHP;
    public Text YouWin;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        BossHP.text = "Enemy HitPoints: " + hitPoints;
        if (hitPoints <= 0)
        {
            Destroy(this.gameObject);
            YouWin.text = "Congratulations! You managed to escape!";
            YouWin.gameObject.SetActive(true);
            GameManager.Instance.youWin = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Shot"))
        {
            hitPoints--;
            Destroy(collision.gameObject);
        }
    }
}
