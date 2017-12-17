using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Gas : MonoBehaviour {

    public Image GasBar;
    public float GasValue = 1.5f;

    float timedEvent = 1;
    float timeTracker = 0;
  

    

    // Use this for initialization
   
    // Update is called once per frame
    void Update()
    {
        GasBar.fillAmount = GasValue;

        timeTracker += Time.deltaTime;
        if (timeTracker >= timedEvent)
        {
            if (GasValue > 0.1f)
            {
                GasValue -= 0.20f;
                timeTracker -= timedEvent;

            }

            else
            {
                SceneManager.LoadScene("GameOver");
            }
        }
        
   }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.layer == LayerMask.NameToLayer("Fuel1"))
        {
            GasValue += 1f;
            Destroy(coll.gameObject);
        }


    }
}
