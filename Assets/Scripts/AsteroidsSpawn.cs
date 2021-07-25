using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsSpawn : MonoBehaviour
{
    public GameObject asteroids;
    float timer;
    public float tempEntreAsteroids;
    

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        float eixoY = Random.Range(-5, 5);
        Vector3 curPos = new Vector3(9f, eixoY, -1);
        timer += Time.deltaTime;
        if (timer > tempEntreAsteroids)
        {
            timer -= tempEntreAsteroids;
            Instantiate(asteroids, curPos, transform.rotation);
        }
    }

    
}
