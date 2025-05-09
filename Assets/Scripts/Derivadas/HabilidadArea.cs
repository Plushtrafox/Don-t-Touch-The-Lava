using UnityEngine;
using System;

public class HabilidadArea : Habilidad
{
    
    public GameObject prefabArea;

    public override void Activar(GameObject portador)
    {
        if (!PuedeUsarse()) return;
        base.Activar(portador);
        Instantiate(prefabArea, GameObject.FindGameObjectWithTag("enemigo").transform.position, Quaternion.identity);
    }
}
