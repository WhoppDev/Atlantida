using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumping : MonoBehaviour
{
    public Animator anim;

    public void ChamarPulo()
    {
        anim.SetTrigger("Pular");
    }

    public void Saltar()
    {
        SceneManager.LoadScene("FallAtlantis");
    }
}
