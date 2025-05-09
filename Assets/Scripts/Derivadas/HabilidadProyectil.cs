using UnityEngine;

public class HabilidadProyectil : Habilidad
{
    public GameObject prefabProyectil;
    public float daño = 10f;

    public override void Activar(GameObject portador)
    {
        if (!PuedeUsarse()) return;
        base.Activar(portador);
        Instantiate(prefabProyectil, portador.transform.position, Quaternion.identity);
    }
}
