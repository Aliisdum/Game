using UnityEngine;

public class S : MonoBehaviour
{
    public float speed = 10.0f;        // Speed of the car.
    public float rotationSpeed = 100.0f;  // Rotation speed of the car.

    private float horizontalInput;
    private float verticalInput;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get input from the player.
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // Move the car forward and backward.
        float movement = verticalInput * speed;
        rb.AddForce(transform.forward * movement);

        // Rotate the car.
        float rotation = horizontalInput * rotationSpeed;
        Quaternion deltaRotation = Quaternion.Euler(Vector3.up * rotation * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
