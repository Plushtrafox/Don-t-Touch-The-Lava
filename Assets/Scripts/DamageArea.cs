using System.Collections.Generic;
using UnityEngine;

public class AreaDeDa�oConCooldown : MonoBehaviour
{
    public float da�o = 5f;
    public float intervaloDa�o = 1f;
    public float duracion = 5f;
    public string etiquetaObjetivo = "Enemigo";

    // Registro de objetivos y su tiempo de �ltimo da�o
    private Dictionary<PortadorBase, float> tiempoUltimoDa�o = new Dictionary<PortadorBase, float>();

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

                if (!tiempoUltimoDa�o.ContainsKey(objetivo))
                {
                    tiempoUltimoDa�o[objetivo] = -Mathf.Infinity;
                }

                if (tiempoActual >= tiempoUltimoDa�o[objetivo] + intervaloDa�o)
                {
                    objetivo.RecibirDa�o(da�o);
                    tiempoUltimoDa�o[objetivo] = tiempoActual;
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Limpiar objetivo al salir del �rea
        PortadorBase objetivo = other.GetComponent<PortadorBase>();
        if (objetivo != null && tiempoUltimoDa�o.ContainsKey(objetivo))
        {
            tiempoUltimoDa�o.Remove(objetivo);
        }
    }
}
