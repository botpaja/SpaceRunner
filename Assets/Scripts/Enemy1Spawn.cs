using UnityEngine;

public class Enemy1Spawn : MonoBehaviour
{
    public GameObject enemy1;
    float timer;
    public float tempEntreInimigos;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        float eixoY = Random.Range(-5, 5);
        Vector3 curPos1 = new Vector3(9f, eixoY, -1);
        Vector3 curPos2 = new Vector3(10f, eixoY, -1);
        Vector3 curPos3 = new Vector3(11f, eixoY, -1);
        timer += Time.deltaTime;
        if (timer > tempEntreInimigos)
        {
            timer -= tempEntreInimigos;
            Instantiate(enemy1, curPos1, transform.rotation);
            Instantiate(enemy1, curPos2, transform.rotation);
            Instantiate(enemy1, curPos3, transform.rotation);
        }
    }


}
