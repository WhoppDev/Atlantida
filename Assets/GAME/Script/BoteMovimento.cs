using UnityEngine;

public class BoteMovimento : MonoBehaviour
{
    public float velocidade = 5;
    public Transform target;
    public Rigidbody rb;
    public OlhoAberto olhoAberto;
    public GameObject player;


    // Movimentar do ponto inicial até o ponto final
    void FixedUpdate()
    {
        MovimentarBarco();
    }

    void MovimentarBarco()
    {
        if (olhoAberto.boteMovimento)
        {
            Vector3 direcao = target.position - transform.position;
            rb.MovePosition(transform.position + direcao.normalized * velocidade * Time.deltaTime);


            if (Vector3.Distance(transform.position, target.position) < 0.1f)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                olhoAberto.boteMovimento = false;
            }
        }
    }
}
