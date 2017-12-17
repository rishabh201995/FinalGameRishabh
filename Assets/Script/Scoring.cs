using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {


    public GameObject Score;
    int score = 0;

    public void addscore(int sc)
    {
        score = score + sc;
        Score.GetComponent<Text>().text = "Score" + score;
    }
}
