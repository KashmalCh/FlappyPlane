using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour {
    public float XAxis;
    public float YAxis;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        transform.gameObject.SetActive(false);
        transform.position = new Vector3(XAxis, YAxis, 0);
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        Score.IsPlaying = false;
        Score.IsOver = true;
    }
}
