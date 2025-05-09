using UnityEngine;
using UnityEngine.UIElements;

public class HabilidadProyectil : Habilidad
{
    public GameObject prefabProyectil;
    public float daño = 10f;
    Vector2 PosicionEnemiga;
    Vector2 DireccionEnemiga;
   
    public override void Activar(GameObject portador)
    {
        if (!PuedeUsarse()) return;
        base.Activar(portador);
        GameObject proyectilDisparado= Instantiate(prefabProyectil);
        

        // portador.transform.position = GameObject.FindWithTag("enemigo").transform.position, Quaternion.identity
        proyectilDisparado.transform.position = portador.transform.position;
        PosicionEnemiga = GameObject.FindWithTag("enemigo").transform.position;
        DireccionEnemiga = PosicionEnemiga - (Vector2)proyectilDisparado.transform.position;
        if(proyectilDisparado.TryGetComponent<Rigidbody2D>(out Rigidbody2D rb))
        {
            //rb.MovePosition(DireccionEnemiga * 2 * Time.fixedDeltaTime);
            rb.AddForce(DireccionEnemiga * 2, ForceMode2D.Impulse);
        }



    }
}
