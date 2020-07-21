using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsController : MonoBehaviour
{
    [SerializeField]
    GameManager gm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.setLose();
    }
}
