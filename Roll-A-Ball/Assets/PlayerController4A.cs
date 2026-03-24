using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController4A : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public float moveForce;

    private Vector2 movementVector;

    // Called once per physics-tic (fixed rate)
    void FixedUpdate()
    {
        Vector3 accVec = new Vector3(movementVector.x, 0f, movementVector.y);
        rb.AddForce(accVec * moveForce, ForceMode.Force);
    }

    void OnJump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    void OnMove(InputValue movementValue)
    {
        movementVector = movementValue.Get<Vector2>();
        Debug.Log(movementVector);
    }
}
