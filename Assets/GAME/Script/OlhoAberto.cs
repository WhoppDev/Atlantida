using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OlhoAberto : MonoBehaviour
{
    public Animator anim;
    public AudioClip som;

    public bool boteMovimento;

    // Start is called before the first frame update
    void Start()
    {
        boteMovimento = false; 
        StartCoroutine("AbrirOlhos");
        AudioSource.PlayClipAtPoint(som, transform.position);
        
    }

    IEnumerator AbrirOlhos()
    {
        //Aguardar 10 segundos e abrir os olhos
        yield return new WaitForSeconds(10);
        anim.SetBool("OlhoAberto", true);
        boteMovimento = true;
    }

}
