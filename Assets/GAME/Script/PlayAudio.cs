using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioClip fala;
    public GameObject sair;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tocando som: " + other);
        if (other.CompareTag("Player"))
        {
            Debug.Log("Tocando som");
            AudioManager.PlaySound(fala);
            sair.SetActive(true);
        }
    }
}
