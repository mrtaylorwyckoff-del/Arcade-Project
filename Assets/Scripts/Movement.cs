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
    private Animator anim;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        rb2d.linearVelocityX = _movement;
        rb2d.linearVelocityY = _ymovement;

        if(rb2d.linearVelocityX != 0)
        {
            anim.Play("KnightWalk");
            if(rb2d.linearVelocityX < 0)
            {
                spriteRenderer.flipX = true;
            }
            if(rb2d.linearVelocityX > 0)
            {
                spriteRenderer.flipX = false;
            }
        }
        else
        {
            Debug.Log("you still twih");
            anim.Play("KnightIdle");
        }

    }


    public void Move(InputAction.CallbackContext ctx)
    {
        _movement = ctx.ReadValue<Vector2>().x * moveSpeed;
        _ymovement = ctx.ReadValue<Vector2>().y * moveSpeed;

    }
}