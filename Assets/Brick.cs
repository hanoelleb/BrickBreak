using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField]
    GameObject particleEffect;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator breakCoroutine()
    {
        var particle = Instantiate(particleEffect, this.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        Destroy(particle);
        Destroy(this.gameObject);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(breakCoroutine());
    }
}
