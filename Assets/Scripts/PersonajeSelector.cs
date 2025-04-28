using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NuevoPersonaje", menuName = "Personaje")]
public class PersonajeSelector : ScriptableObject
{
    public GameObject personajeJugable;
    public Sprite imagen;
    public string nombre;
}
