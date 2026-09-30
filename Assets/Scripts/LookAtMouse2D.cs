using UnityEngine;
using UnityEngine.InputSystem;

public class LookAtMouse2D : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRigidbody;

    private bool facingRight = true;

    void Update()
    {
        //updates direction if moving left (-) or right (+)      
        if (playerRigidbody != null)
        {
            if (playerRigidbody.linearVelocity.x > 0.1f)
            {
                facingRight = true;
                Debug.Log("yeh u movin right");
            }
            else if (playerRigidbody.linearVelocity.x < -0.1f)
            {
                facingRight = false;
                Debug.Log("nah u movin left twih");
            }
        }

        //mouse screen position -> world position
        if (Mouse.current == null) return;
        Vector2 mouseScreenPosition = Mouse.current.position.ReadValue();
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);

        //vector from center of player to mouse
        Vector2 direction = mousePosition - transform.position;
        float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

       //area above head
        if (targetAngle >= 50f && targetAngle <= 130f)
        {
            return;
        }

        //area below feet
        if (targetAngle >= -130f && targetAngle <= -50f)
        {
            return;
        }

        if (facingRight)
        {
            if (targetAngle >= -90f && targetAngle <= 90f)
            {
                transform.rotation = Quaternion.Euler(0, 0, targetAngle);
            }
        }
        else
        {
            if (targetAngle > 90f || targetAngle < -90f)
            {
                transform.rotation = Quaternion.Euler(0, 0, targetAngle);
            }
        }
    }
}
