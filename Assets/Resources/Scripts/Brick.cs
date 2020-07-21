using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField]
    GameObject particleEffect;

    [SerializeField]
    GameManager gm;

    [SerializeField]
    AudioSource destroyNoise;

    // Start is called before the first frame update
    void Start()
    {
        if (gm == null)
          gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        if (destroyNoise == null)
            destroyNoise = GameObject.FindGameObjectWithTag("DestroyNoise").GetComponent<AudioSource>();
    }

    IEnumerator breakCoroutine()
    {
        gm.increaseScore(10);
        var particle = Instantiate(particleEffect, this.transform.position, Quaternion.identity);
        destroyNoise.Play();
        yield return new WaitForSeconds(0.5f);
        Destroy(particle);
        Destroy(this.gameObject);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(breakCoroutine());
    }
}
