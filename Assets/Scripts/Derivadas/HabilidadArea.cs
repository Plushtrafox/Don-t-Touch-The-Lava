using UnityEngine;

public class HabilidadArea : Habilidad
{
    public GameObject prefabArea;

    public override void Activar(GameObject portador)
    {
        if (!PuedeUsarse()) return;
        base.Activar(portador);
        Instantiate(prefabArea, portador.transform.position, Quaternion.identity);
    }
}
