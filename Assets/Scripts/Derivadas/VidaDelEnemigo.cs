using UnityEngine;

public class VidaDelEnemigo : MonoBehaviour
{
    [Header("Configuración del enemigo")]
    public string enemyTag = "Enemigo";
    public int maxHealth = 100;
    private int currentHealth;

    [Header("Opcional: Efectos")]
    public GameObject deathEffect;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Método público para recibir daño
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log($"{gameObject.name} recibió {damage} de daño. Vida restante: {currentHealth}");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Método para destruir al enemigo
    void Die()
    {
        Debug.Log($"{gameObject.name} ha muerto.");

        if (deathEffect != null)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
    }

    // Método opcional para detectar colisiones con proyectiles u otras fuentes de daño
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Proyectil"))
        {
            // Puedes hacer que el proyectil tenga un script con un valor de daño
            int damage = 10; // Valor por defecto o extraído del proyectil
            TakeDamage(damage);
        }
    }
}

