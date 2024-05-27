using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarParadaBarco : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip barcoParando;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.loop = false;
            audioSource.clip = barcoParando;
            audioSource.Play();
        }
    }
}
