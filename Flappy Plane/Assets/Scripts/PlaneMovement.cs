using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour {

    public float JumpSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Jump();
      
	}
    void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, JumpSpeed); 
    }


}
