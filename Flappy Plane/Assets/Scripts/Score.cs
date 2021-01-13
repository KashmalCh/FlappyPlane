using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Score : MonoBehaviour {
    public static Score Instace;
    public static int ScoreValue;
    public static bool IsPlaying=false;
    public static bool IsOver=false;

    void Awake()
    {
   
        Instace = this;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        ScoreUpdater();
    }
     void ScoreUpdater()
    {
        ScoreValue += 1;
    }
   public void TurnOn()
     {
         IsPlaying = true;
     }
}
