using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour {

    AudioSource Coin;

    public int Score;
    public void Start()
    {
        AudioSource[] audiosources = GetComponents<AudioSource>();
        Coin = audiosources[0];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            GameObject.Find("Score").GetComponent<Scoring>().addscore(Score);
            Destroy(gameObject);
            GameObject.Find("Coin").GetComponent<AudioSource>().Play();

        }
    }
    
}
