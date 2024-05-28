using UnityEngine;

public class SaltarDoBarco : MonoBehaviour
{
    public GameObject player;
    public GameObject desativar;

    public Jumping jumping;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FimdoBarco"))
        {
            desativar.SetActive(false);
            player.SetActive(true);

            jumping.ChamarPulo();

        }
    }
}
