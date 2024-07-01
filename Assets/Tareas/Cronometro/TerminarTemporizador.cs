using UnityEngine;

public class TerminarTemporizador : MonoBehaviour
{ 
    [SerializeField] private Controlador controlador;
    public ListaDeCheckpoints checkpoints;
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(checkpoints.laps==3)
            {  
                controlador.DesactivarTemporizador();
            }
         
        }
    }
}
