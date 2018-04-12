using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpentheDoor : MonoBehaviour {
    GameObject Wall;
    GameObject bridge;
    // Use this for initialization
    void Start () {
        //Wall = GameObject.Find("Wall");
        bridge = GameObject.Find("Bridge");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Wall.SetActive(false);

            Bridge bridge_s = bridge.GetComponent<Bridge>();
            bridge_s.Appear();
        }
    }
}
