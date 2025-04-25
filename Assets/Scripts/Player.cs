using UnityEngine;
using System;
using System.Collections.Generic;


public abstract class Player : MonoBehaviour
{
     public string nombre;
    public float vidaMax;
    public float vidaActual;
    public List<Habilidad> habilidades;
     public virtual void RecibirDanio(float cantidad)
    {
        vidaActual -= cantidad;
        vidaActual = Mathf.Clamp(vidaActual, 0, vidaMax);
        Debug.Log($"{nombre} recibió {cantidad} de daño. Vida actual: {vidaActual}");
    }
    public abstract void UsarHabilidad(int index);
}
