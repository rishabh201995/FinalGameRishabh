using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarDestroy : MonoBehaviour {

    [SerializeField]
    GameObject mDeathParticleEmitter;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag =="ground")
        {

            Instantiate(mDeathParticleEmitter, transform.position, transform.rotation);
            Destroy(transform.parent.gameObject);
            SceneManager.LoadScene("GameOver");
        }


    }
}

// Use this for initialization

