using UnityEngine;

public class Lava : MonoBehaviour
{
    [SerializeField][Range(0, 100)] private int damage = 10;

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PortadorBase portadorBase))
        {
            portadorBase.RecibirDaño(damage);
        }
    }*/

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PortadorBase portadorBase))
        {
            portadorBase.RecibirDaño(damage * Time.deltaTime);
        }
    }
}
