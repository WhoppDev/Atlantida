using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPortas : MonoBehaviour
{
    public GameObject porta1; 
    public GameObject porta2; 

    // Velocidade de rotação
    public float rotationSpeed = 90f;


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            if (porta1 != null)
            {
                RotateDoor(porta1, Vector3.right);
            }

            if (porta2 != null)
            {
                RotateDoor(porta2, Vector3.left);
            }
        }
    }


    private void RotateDoor(GameObject door, Vector3 rotationAxis)
    {
        door.transform.Rotate(rotationAxis, 90f);
    }
}