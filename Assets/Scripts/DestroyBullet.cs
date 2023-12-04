using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Destroys bullet AND zombie if they collide with each other, OR destroys just the bullet if it collides with anything else
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
