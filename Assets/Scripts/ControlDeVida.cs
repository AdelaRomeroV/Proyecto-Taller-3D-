using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeVida : MonoBehaviour
{
    public bool recibioDa�o = false;
    private Turbo turboPlayer;

    private void Awake()
    {
        turboPlayer = GetComponent<Turbo>();
    }

    private void FixedUpdate()
    {
        recibioDa�o = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Pared"))
        {
            turboPlayer.GestionarEnergia(20);
            recibioDa�o = true;
        }
        if (collision.gameObject.CompareTag("Hazards"))
        {
            CountPeligro turbo = collision.gameObject.GetComponent<CountPeligro>();
            if(turbo != null) { turboPlayer.GestionarEnergia(turbo.count); }
            recibioDa�o = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AtaqueEnemigo"))
        {
            turboPlayer.GestionarEnergia(2);
            recibioDa�o = true;
        }
    }
}
