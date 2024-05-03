using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeVida : MonoBehaviour
{
    public bool recibioDaņo = false;

    private void FixedUpdate()
    {
        recibioDaņo = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Pared"))
        {
            recibioDaņo = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AtaqueEnemigo"))
        {
            recibioDaņo = true;
        }
    }
}
