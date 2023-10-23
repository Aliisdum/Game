using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartController : MonoBehaviour
{
    public float moveSpeed = 10f;    // Speed of the go-kart
    public float turnSpeed = 50f;    // Turning speed

    private float horizontalInput;
    private float verticalInput;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get input from the player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // Move the go-kart
        Vector3 movement = transform.forward * verticalInput * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        // Rotate the go-kart
        float rotation = horizontalInput * turnSpeed * Time.fixedDeltaTime;
        Quaternion deltaRotation = Quaternion.Euler(0, rotation, 0);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
