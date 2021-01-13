using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      
	}
   public void Reset()
    {
        Score.IsOver = false;
        Score.IsPlaying = true;
        Spawner.OwnChecker = true;
        Score.ScoreValue = 0;
    }
}
