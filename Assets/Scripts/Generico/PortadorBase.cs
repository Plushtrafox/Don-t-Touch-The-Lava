using UnityEngine;

public class PortadorBase : MonoBehaviour
{
    public float vidaMaxima = 100f;
    protected float vidaActual;

    public virtual void RecibirDa�o(float cantidad)
    {
        vidaActual -= cantidad;
        if (vidaActual <= 0)
        {
            Muerte();
        }
    }

    public virtual void Curar(float cantidad)
    {
        vidaActual = Mathf.Min(vidaActual + cantidad, vidaMaxima);
    }

    protected virtual void Muerte()
    {
        Debug.Log($"{gameObject.name} ha muerto.");
        // Aqu� puedes poner animaci�n o destrucci�n
    }

    protected virtual void Start()
    {
        vidaActual = vidaMaxima;
    }
}
