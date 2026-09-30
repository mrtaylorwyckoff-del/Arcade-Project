using UnityEngine;
using UnityEngine.InputSystem;
public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movementInput;

    public Vector2 CurrentInput => movementInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }

    void Update()
    {
        rb.MovePosition(rb.position + movementInput * moveSpeed * Time.fixedDeltaTime);
    }
}
