using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody rb; // Referentie naar Rigidbody
    public float moveSpeed; // Snelheid van bewegen moveSpeed type float
    public float jumpForce;// Kracht van sprong jumpForce type float

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>(); // Haal Rigidbody component op van het gameobject
        Debug.Log("Speler klaar!");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W)) // Beweging met pijltjestoetsen
        {
            rb.AddForce(0, 0, moveSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-moveSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -moveSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(moveSpeed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space)) // Simpele Sprong met spatie , gebruik rigidbody
        {
            rb.AddForce(0, jumpForce, 0);
            Debug.Log("Springen!");
        }
    }
}