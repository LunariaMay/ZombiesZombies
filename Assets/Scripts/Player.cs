using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Sets player control/speed
    private float speed = 2;
    private float horizontalSpeed = 2;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        forwardInput = Input.GetAxisRaw("Vertical");

        // Moves player
        transform.Translate(Vector3.up * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed * horizontalInput);
    }
}
