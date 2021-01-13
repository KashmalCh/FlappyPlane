using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdleMovement : MonoBehaviour {

    public float MovementSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Score.IsPlaying)
        {
          
            transform.position -= new Vector3(MovementSpeed * Time.deltaTime, 0, 0);
        }
      
	}
    void OnBecameInvisible()
    {
      
        Destroy(gameObject);
    }
}
