using System.Reflection.Metadata;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playermovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    private float _movement;
    private float _ymovement;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        rb2d.linearVelocityX = _movement;
        rb2d.linearVelocityY = _ymovement;
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        _movement = ctx.ReadValue<Vector2>().x * moveSpeed;
        _ymovement = ctx.ReadValue<Vector2>().y * moveSpeed;

    }
}