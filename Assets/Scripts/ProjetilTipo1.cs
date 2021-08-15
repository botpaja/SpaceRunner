using UnityEngine;

public class ProjetilTipo1 : MonoBehaviour
{
    public float reloadTime;
    public GameObject projetil;
    public Transform origemProjetil;

    private float timer;
    public int tipoArma = 0;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            tipoArma = (tipoArma + 1) % 2;
        }

        else if (Input.GetKey(KeyCode.Space) && tipoArma == 0)
        {
            
            timer += Time.deltaTime;
            if (timer > reloadTime / 2)
            {
                timer -= reloadTime / 2;
                Instantiate(projetil, origemProjetil.position, origemProjetil.rotation);
            }
        }

        else if (Input.GetKey(KeyCode.Space) && tipoArma == 1)
        {
            Vector3 projetilsec = new Vector3(origemProjetil.position.x, (float)(origemProjetil.position.y - 0.5), origemProjetil.position.z);
            Vector3 projetilsec2 = new Vector3(origemProjetil.position.x, (float)(origemProjetil.position.y + 0.5), origemProjetil.position.z);
            timer += Time.deltaTime;
            if (timer > reloadTime)
            {
                timer -= reloadTime;
                Instantiate(projetil, origemProjetil.position, origemProjetil.rotation);
                Instantiate(projetil, projetilsec, origemProjetil.rotation);
                Instantiate(projetil, projetilsec2, origemProjetil.rotation);
            }
        }
        
        else
        {
            timer = reloadTime;
        }
    }
}
