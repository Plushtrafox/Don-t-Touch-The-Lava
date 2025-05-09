using UnityEngine;

public class PortadorBase : MonoBehaviour
{
    public float vidaMaxima = 100f;
    private float vidaActual;

    private float CurrentLife
    {
        get => vidaActual;
        set
        {
            vidaActual = Mathf.Clamp(value, 0, vidaMaxima);

            if(vidaActual == 0) Muerte();
        }
    }

    protected virtual void Start()
    {
        vidaActual = vidaMaxima;
    }

    public virtual void RecibirDa�o(float cantidad)
    {
        CurrentLife -= cantidad;
    }

    public virtual void Curar(float cantidad)
    {
        CurrentLife += cantidad;
    }

    protected virtual void Muerte()
    {
        Debug.Log($"{gameObject.name} ha muerto.");
        // Aqu� puedes poner animaci�n o destrucci�n
    }
}
