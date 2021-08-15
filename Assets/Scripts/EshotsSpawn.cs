using UnityEngine;

public class EshotsSpawn : MonoBehaviour
{
    public GameObject eshots;
    public Transform origemEshots;
    float timer;
    public float tempEntreEshots;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > tempEntreEshots)
        {
            timer -= tempEntreEshots;
            Instantiate(eshots, origemEshots.position, origemEshots.rotation);
        }
    }
}
