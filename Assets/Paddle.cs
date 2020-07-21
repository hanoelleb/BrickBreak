using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    float SPEED = 5.0f;

    [SerializeField]
    float MAX_X = 7.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        processInput();
    }

    void processInput()
    {
        var input = Input.GetAxisRaw("Horizontal");
        if (input != 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * input * SPEED);

            Vector3 pos = transform.position;
            pos.x = Mathf.Clamp(pos.x, -MAX_X, MAX_X);
            transform.position = pos;
        }
    }
}
