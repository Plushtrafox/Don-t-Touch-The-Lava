using UnityEngine;

public class ScriptBala : MonoBehaviour
{
    public GameObject Bala;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider)
        {
            Destroy(gameObject);
        }
    }

}
