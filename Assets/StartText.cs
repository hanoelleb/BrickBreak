using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour
{
    Text start;

    string message = "Press <space> to start";

    // Start is called before the first frame update
    void Start()
    {
        start = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            start.text = "";
        }
    }
}
