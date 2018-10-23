using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision coll)
    {
        print("ship collided");
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel("Win");
#pragma warning restore CS0618 // Type or member is obsolete
    }
}
