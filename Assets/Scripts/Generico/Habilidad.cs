using UnityEngine;

public abstract class Habilidad : MonoBehaviour
{
    public float enfriamiento = 2f;
    protected float tiempoUltimoUso = -Mathf.Infinity;

    public virtual bool PuedeUsarse()
    {
        return Time.time >= tiempoUltimoUso + enfriamiento;
    }

    public virtual void Activar(GameObject portador)
    {
        tiempoUltimoUso = Time.time;
    }
}
