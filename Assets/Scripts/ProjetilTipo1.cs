using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilTipo1 : MonoBehaviour
{
    public float reloadTime;
    public GameObject projetil;
    public Transform origemProjetil;

    private float timer;



    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
            timer += Time.deltaTime;
            if (timer > reloadTime)
            {
                timer -= reloadTime;
                Instantiate(projetil, origemProjetil.position, origemProjetil.rotation);
            }
        }
        else
        {
            timer = reloadTime;
        }
    }
}
