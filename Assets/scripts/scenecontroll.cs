using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenecontroll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void scene(string scenename)
    {
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(scenename);
#pragma warning restore CS0618 // Type or member is obsolete
    }

    public void quit()
    {
        Application.Quit();
    }
}
