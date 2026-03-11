using UnityEngine;
using UnityEngine.InputSystem;

namespace K4B
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody rb;
        private Vector2 movementVector;

        [Range(0f, 10f)]
        public float speed;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            //rb.AddForce(force, ForceMode.Impulse);
        }

        void FixedUpdate()
        {
            Vector3 force = new Vector3(movementVector.x, 0f, movementVector.y);
            rb.AddForce(force * speed, ForceMode.Force);
        }

        void OnMove(InputValue inputValue)
        {
            movementVector = inputValue.Get<Vector2>();
        }
    }
}