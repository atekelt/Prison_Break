using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imagecontrol : MonoBehaviour {
    bool stat;
    private playercontrol player;
    // Use this for initialization
    void Start () {
        //playercontrol player = new playercontrol();
        player = GameObject.FindObjectOfType<playercontrol>();
        gameObject.GetComponent<imagecontrol>().enabled = false;
        
	}
	
	// Update is called once per frame
	void Update () {
        stat = player.calstat;
        if(stat == false)
        {
            gameObject.GetComponent<imagecontrol>().enabled = false;
        }

        else if (stat == true)
        {
            gameObject.GetComponent<imagecontrol>().enabled = true;
        }
	}
}
