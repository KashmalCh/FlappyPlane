using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsGameOver : MonoBehaviour {
    public GameObject EndGame;
    public Button Restart;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Score.IsOver)
        {
            EndGame.transform.gameObject.SetActive(true);
            Restart.transform.gameObject.SetActive(true); 
        }
        else if (Score.IsOver == false)
        {
            EndGame.transform.gameObject.SetActive(false);
            Restart.transform.gameObject.SetActive(false); 
        }
		
	}
}
