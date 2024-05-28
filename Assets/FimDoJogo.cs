using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FimDoJogo : MonoBehaviour
{
    public GameObject anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetActive(true);
        }
    }
}
