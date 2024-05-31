using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeVida : MonoBehaviour
{
    public bool recibioDaņo = false;
    private Turbo turboPlayer;

    private void Awake()
    {
        turboPlayer = GetComponent<Turbo>();
    }

    private void FixedUpdate()
    {
        recibioDaņo = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Pared"))
        {
            turboPlayer.GestionarEnergia(20);
            recibioDaņo = true;
        }
        if (collision.gameObject.CompareTag("Hazards"))
        {
            CountPeligro turbo = collision.gameObject.GetComponent<CountPeligro>();
            if(turbo != null) { turboPlayer.GestionarEnergia(turbo.count); }
            recibioDaņo = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AtaqueEnemigo"))
        {
            turboPlayer.GestionarEnergia(2);
            recibioDaņo = true;
        }
    }
}
