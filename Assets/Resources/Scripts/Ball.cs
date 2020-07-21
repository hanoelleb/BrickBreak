using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;

    float ballForce = 150f;
    bool start = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && !start)
        {
            transform.SetParent(null);
            rb.AddForce(new Vector2(ballForce, ballForce));
            start = true;
        }
    }

    public void resetBall()
    {
        start = false;
        rb.velocity = Vector3.zero;
        transform.SetParent(GameObject.FindGameObjectWithTag("Paddle").transform);
        transform.localPosition = new Vector3(0, 1.2f);
    }
}
