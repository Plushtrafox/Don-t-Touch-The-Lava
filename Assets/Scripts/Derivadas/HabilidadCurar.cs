using UnityEngine;

public class HabilidadCurar : Habilidad
{
    public float cantidadCuracion = 20f;

    public override void Activar(GameObject portador)
    {
        if (!PuedeUsarse()) return;
        base.Activar(portador);
        portador.GetComponent<PortadorBase>().Curar(cantidadCuracion);
    }
}
