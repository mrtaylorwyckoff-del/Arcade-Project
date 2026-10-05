using UnityEngine;
using UnityEngine.InputSystem;

public class LookAtMouse2D : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRigidbody;

    private bool facingRight = true;

    void Update()
    {
        //mouse screen position -> world position
        if (Mouse.current == null) return;
        Vector2 mouseScreenPosition = Mouse.current.position.ReadValue();
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);

        //vector from center of player to mouse
        Vector2 direction = mousePosition - transform.position;
        float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


        transform.rotation = Quaternion.Euler(0, 0, targetAngle);

    }
    }