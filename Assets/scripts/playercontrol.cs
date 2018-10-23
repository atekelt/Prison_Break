using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontrol : MonoBehaviour {

    
    public bool calstat = false;
    GameObject hold;
    public Text endtext;
    public string msg5;
    butt buttons;
    void Start()
    {
        calstat = false;
        buttons = GameObject.FindObjectOfType<butt>();
        
    }
    void OnCollisionEnter(Collision coll)
    {
        
        
            calstat = true;
            print("collided with" + coll.gameObject.name);
            hold = coll.gameObject;
           // coll.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, coll.gameObject.transform.position.z + 55);

    }

    void OnCollisionExit(Collision coll)
    {
        print("exited");
        calstat = false;
    }
        void OnTriggerEnter(Collider coll1)
    {
        print("trigger");
       // coll1.gameObject.GetComponent<Rigidbody>().transform.position = new Vector3(0, 0, 15);
    }
    // Use this for initialization
    
	
	// Update is called once per frame
	void Update () {
        if (buttons.msg4 == "correct")
        {
            hold.GetComponent<Rigidbody>().transform.position = new Vector3(hold.transform.position.x, hold.transform.position.y, hold.gameObject.transform.position.z + 1.5f);
            endtext.text = "Correct Press B to go back";
            buttons.msg4 = "";
        }
    }

    public bool shownum()
    {
        return calstat;
    }
}
