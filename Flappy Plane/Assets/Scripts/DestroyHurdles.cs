using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHurdles : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Score.IsOver==true)
        {
          
            Destroy(gameObject);
        }
		
	}
}
