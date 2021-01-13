using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreOnBoard : MonoBehaviour {
    public Text PlayerScore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ScorePrinter();
	}
    void ScorePrinter()
    {
        PlayerScore.text = "Score : " + Score.ScoreValue; 
    }
}
