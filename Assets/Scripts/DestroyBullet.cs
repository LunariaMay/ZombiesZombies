using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Destroys bullet after a few moments
        Destroy(this.gameObject, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
