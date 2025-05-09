using System.Collections.Generic;
using UnityEngine;

public class AreaDeDañoConCooldown : MonoBehaviour
{
    public float daño = 5f;
    public float intervaloDaño = 1f;
    public float duracion = 5f;
    public string etiquetaObjetivo = "Enemigo";

    // Registro de objetivos y su tiempo de último daño
    private Dictionary<PortadorBase, float> tiempoUltimoDaño = new Dictionary<PortadorBase, float>();

    private void Start()
    {
        Destroy(gameObject, duracion);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag(etiquetaObjetivo))
        {
            PortadorBase objetivo = other.GetComponent<PortadorBase>();
            if (objetivo != null)
            {
                float tiempoActual = Time.time;

                if (!tiempoUltimoDaño.ContainsKey(objetivo))
                {
                    tiempoUltimoDaño[objetivo] = -Mathf.Infinity;
                }

                if (tiempoActual >= tiempoUltimoDaño[objetivo] + intervaloDaño)
                {
                    objetivo.RecibirDaño(daño);
                    tiempoUltimoDaño[objetivo] = tiempoActual;
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Limpiar objetivo al salir del área
        PortadorBase objetivo = other.GetComponent<PortadorBase>();
        if (objetivo != null && tiempoUltimoDaño.ContainsKey(objetivo))
        {
            tiempoUltimoDaño.Remove(objetivo);
        }
    }
}
