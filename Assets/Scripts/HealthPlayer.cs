using UnityEngine;

public class HealthPlayer : Player
{
public override void UsarHabilidad(int index)
    {
        if (index >= 0 && index < Habilidades.Count)
        {
            Habilidad habilidad = Habilidades[index];

            if (vidaActual >= habilidad.costo)
            {
                vidaActual -= habilidad.costo;
                habilidad.Activar(this);
                Debug.Log($"{nombre} usó {habilidad.nombre} (vida restante: {vidaActual})");
            }
            else
            {
                Debug.Log("No hay suficiente vida para usar la habilidad.");
            }
        }
    }
}
