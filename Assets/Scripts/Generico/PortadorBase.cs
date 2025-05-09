using UnityEngine;

public class PortadorBase : MonoBehaviour
{
    public float vidaMaxima = 100f;
    protected float vidaActual;

    public virtual void RecibirDaño(float cantidad)
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
        // Aquí puedes poner animación o destrucción
    }

    protected virtual void Start()
    {
        vidaActual = vidaMaxima;
    }
}
