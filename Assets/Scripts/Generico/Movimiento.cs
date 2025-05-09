using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float moveSpeed = 2f;  // Velocidad de movimiento
    private Rigidbody2D rb;
    private Vector2 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f; // Asegura que la gravedad no afecta
    }

    void Update()
    {
        // Captura del input de movimiento (WASD)
        float moveX = Input.GetAxisRaw("Horizontal"); // A/D o flechas izquierda/derecha
        float moveY = Input.GetAxisRaw("Vertical");   // W/S o flechas arriba/abajo
        moveDirection = new Vector2(moveX, moveY).normalized; // Normaliza para evitar velocidad diagonal mayor
    }

    void FixedUpdate()
    {
        // Aplicar movimiento usando física
        rb.linearVelocity = moveDirection * moveSpeed;
    }
}