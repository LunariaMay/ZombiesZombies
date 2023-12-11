using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Declares bullet variables
    public float speed = 10.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        // Destroys bullet after a few moments;
        Destroy(transform.parent.gameObject, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
