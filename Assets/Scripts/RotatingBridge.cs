using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBridge : MonoBehaviour {

    public float speed = 20f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
