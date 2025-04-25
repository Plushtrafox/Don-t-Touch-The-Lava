using UnityEngine;

public class ManaPlayer : Player
{
  public float manaMax;
    public float manaActual;

    public override void UsarHabilidad(int index)
    {
        if (index >= 0 && index < habilidades.Count)
        {
            Habilidad habilidad = habilidades[index];

            if (manaActual >= habilidad.costo)
            {
                manaActual -= habilidad.costo;
                habilidad.Activar(this);
                Debug.Log($"{nombre} usó {habilidad.nombre} (mana: {manaActual})");
            }
            else
            {
                Debug.Log("No hay suficiente mana.");
            }
        }
    }
}
