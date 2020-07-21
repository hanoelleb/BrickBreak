using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;

    float ballForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(ballForce, ballForce));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
