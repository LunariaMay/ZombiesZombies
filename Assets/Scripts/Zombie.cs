using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    // Declares call to Game Manager
    private GameManager gameManager;

    // Declares points as an integer
    public int pointValue;

    // Directional and movement declarations
    [SerializeField] float moveSpeed = 2f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;

    // Declares variable for particle system
    public ParticleSystem explosionParticle;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Searches for the player so it can move toward it
        target = GameObject.Find("Player").transform;

        // Calls GameManager as a component
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection = direction;
        }
    }

    private void FixedUpdate()
    {
        if (target)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }

    // Destroys bullet AND zombie if they collide with each other, OR destroys just the bullet if it collides with anything else
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(transform.parent.gameObject);
            if (!gameObject.CompareTag("Player")) 
            {
                gameManager.GameOver(); 
            }
        }

        if (collision.gameObject.CompareTag("Bullet")) 
        {
            gameManager.UpdateScore(pointValue); 
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            Destroy(gameObject);
            Destroy(transform.parent.gameObject);
        }

    }
}
