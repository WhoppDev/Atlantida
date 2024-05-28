using UnityEngine;

public class BoteMovimento : MonoBehaviour
{
    public float velocidade = 5f;
    public Transform target;
    public Rigidbody rb;
    public OlhoAberto olhoAberto;
    public GameObject player;

    void FixedUpdate()
    {
        MovimentarBarco();
    }

    void MovimentarBarco()
    {
        if (olhoAberto.boteMovimento)
        {
            Vector3 direcao = target.position - transform.position;
            rb.MovePosition(transform.position + direcao.normalized * velocidade * Time.fixedDeltaTime);

            if (Vector3.Distance(transform.position, target.position) < 0.1f)
            {
                // Desativar o movimento do barco
                olhoAberto.boteMovimento = false;
            }
        }
    }
}
