using UnityEngine;

public class OndaExpansiva : MonoBehaviour
{
    public float velocidadCrecimiento = 5f;
    public float duracionExplosion = 1f;

    [SerializeField] float explosion;
    private float tiempoInicioExplosion;

    void Start()
    {
        tiempoInicioExplosion = Time.time;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Turbo a = other.GetComponent<Turbo>();
                 a.GestionarEnergia(explosion);
        }
    }

    void Update()
    {
        float tiempoTranscurrido = Time.time - tiempoInicioExplosion;
        float tama�oActual = tiempoTranscurrido * velocidadCrecimiento;

        transform.localScale = new Vector3(tama�oActual, tama�oActual, tama�oActual);

        if (tiempoTranscurrido >= duracionExplosion)
        {
            Destroy(gameObject);
        }
    }
}
