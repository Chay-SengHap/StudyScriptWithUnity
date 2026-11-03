
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f;
    public int maxJumps = 2;

    private Rigidbody rb;
    private int jumpsRemaining;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Player starts with 2 available jumps
        jumpsRemaining = maxJumps;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpsRemaining > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            jumpsRemaining--;

            Debug.Log("Jumps remaining: " + jumpsRemaining);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            // Reset jumps when player lands on the ground
            jumpsRemaining = maxJumps;

            Debug.Log("Player landed! Jumps reset.");
        }
    }
}
