using UnityEngine;

public class ControladorHabilidades : MonoBehaviour
{
    public Habilidad habilidad1;
    public Habilidad habilidad2;
    public Habilidad habilidad3;

    public void CastAbility(int index)
    {
        switch(index)
        {
            case 0:
                habilidad1.Activar(gameObject);
                break;
            case 1:
                habilidad2.Activar(gameObject);
                break;
            case 2:
                habilidad3.Activar(gameObject);
                break;
        }
    }
}
