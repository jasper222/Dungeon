using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour {
    public Vector3 point;
   
	// Use this for initialization
	void Start () {
    GameObject player = GameObject.Find("Player");
        player.transform.position = point;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
