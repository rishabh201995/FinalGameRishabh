using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class BOMB : MonoBehaviour {

    AudioSource Explosion;

    public void Start()
    {
        AudioSource[] audiosources = GetComponents<AudioSource>();
        Explosion = audiosources[0];
    }

    [SerializeField]
    GameObject mDeathParticleEmitter;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject.Find("Explosion").GetComponent<AudioSource>().Play();
            Destroy(col.gameObject);

            Destroy(gameObject);

            Instantiate(mDeathParticleEmitter, transform.position, transform.rotation);
            SceneManager.LoadScene("GameOver");
        }
    }
}

