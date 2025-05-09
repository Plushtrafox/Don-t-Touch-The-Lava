using UnityEngine;

public class ControladorHabilidades : MonoBehaviour
{
    public Habilidad habilidad1;
    public Habilidad habilidad2;
    public Habilidad habilidad3;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) habilidad1.Activar(gameObject);
        if (Input.GetKeyDown(KeyCode.Alpha2)) habilidad2.Activar(gameObject);
        if (Input.GetKeyDown(KeyCode.Alpha3)) habilidad3.Activar(gameObject);
    }
}
