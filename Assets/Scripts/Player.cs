using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{

    // Declares call to bullet prefab
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        // Calls the rigidbody of the player
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Sets player control/speed
    private float speed = 2;
    private float horizontalInput;
    private float forwardInput;
    private Vector2 playerDirection;
    private Rigidbody2D rb; 


    // Update is called once per frame
    void Update()
    {
        // Gets the horizontal/vertical axis for player movement
        horizontalInput = Input.GetAxisRaw("Horizontal");
        forwardInput = Input.GetAxisRaw("Vertical");

        // Moves player
        playerDirection = new Vector2(horizontalInput, forwardInput).normalized;

        // Spawns bullet on click
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        }

    }

    // This is a new method for helping player movement
    void FixedUpdate()
    {
        rb.velocity = new Vector2(playerDirection.x * speed, playerDirection.y * speed);
    }

    // Destroys player upon collision with a zombie
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            Destroy(gameObject);
        }
    }

}