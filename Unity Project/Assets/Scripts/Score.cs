using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //score set to zero
    public static int totalScore = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //updates text and adds +1 to player score in main game when the player chooses correct inputs
        score.text = "Score: " + totalScore;
    }
}
