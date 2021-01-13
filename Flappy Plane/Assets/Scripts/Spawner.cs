using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public List<GameObject> Hurdles;
    public float Delay;
    public GameObject HurdlePosition;
   public static bool OwnChecker= true;
 
	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

        if(OwnChecker==true && Score.IsPlaying==true)
        {
            StartCoroutine("Spawn");
            OwnChecker = false;
        }
        else if(OwnChecker == false && Score.IsPlaying==false)
        {
           
                StopCoroutine("Spawn");
        }
        
       
	}
    IEnumerator Spawn()
    {
        while(true)
        {
            Generate();
            if (Score.IsPlaying == false) break;
            yield return new WaitForSeconds(Delay);
        }
    }
    void Generate()
    {
        Instantiate(Hurdles[Random.Range(0, Hurdles.Count)], HurdlePosition.transform.position, Quaternion.identity);
    }

}
