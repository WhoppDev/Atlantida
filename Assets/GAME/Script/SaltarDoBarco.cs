using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaltarDoBarco : MonoBehaviour
{
    public GameObject player;
    public GameObject desativar;
    public Animator anim;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FimdoBarco")
        {
            //REmover o player de filho do "desativar" e desativar o "desativar"
            player.transform.parent = null;
            desativar.SetActive(false);
            player.SetActive(true);
            anim.Play("Salto");
        }
    }

    public void Saltar()
    {
        SceneManager.LoadScene("FallAtlantis");
    }
}
