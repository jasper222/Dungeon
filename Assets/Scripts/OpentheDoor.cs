using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpentheDoor : MonoBehaviour {
    public string type;
    GameObject trigger;
    // Use this for initialization
    void Start () {
        trigger = GameObject.Find(type);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(type.Contains("Bridge"))
            {
                Bridge bridge_s = trigger.GetComponent<Bridge>();
                bridge_s.Appear();
            }
            
        }
    }

}
