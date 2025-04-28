using UnityEngine;

public class IniciarJugador : MonoBehaviour
{
    
    private void Start()
    {
        int JugadorIndex= PlayerPrefs.GetInt("JugadorIndex");
    Instantiate(GameManager.instance.personajes[JugadorIndex].personajeJugable, transform.position, Quaternion.identity);
    }

}
