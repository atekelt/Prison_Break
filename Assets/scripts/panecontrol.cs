using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panecontrol : MonoBehaviour {

    public GameObject pane;
    public GameObject players;
    playercontrol player;
    butt buttons;
    public bool msg = false, msg2 = false;
    public string msg3;
    // Use this for initialization
    void Start () {
        player = GameObject.FindObjectOfType<playercontrol>();
        buttons = GameObject.FindObjectOfType<butt>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if(player.calstat == true)
        {
            msg = true;
            if(Input.GetKey(KeyCode.F))
            {
                buttons.press();
            }
        }
        else if(player.calstat == false)
        {
            msg = false;
        }

        if (buttons.pressed == "F")
        {
            if (msg3 != "B")
            {
                pane.SetActive(true);
                players.SetActive(false);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                msg = false;
                msg2 = true;
            }
        }

        if(msg2 == true & Input.GetKey(KeyCode.B))
        { 
                pane.SetActive(false);
                players.SetActive(true);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                msg = true;
                msg2 = false;
                msg3 = "B";       
        }
	}
}
