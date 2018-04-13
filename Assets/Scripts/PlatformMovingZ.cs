using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovingZ : MonoBehaviour {

    public Vector3 movement;
    public float speed = 5f;
    private Vector3 startpos;
    private Vector3 endpos;
    private int dir;
	// Use this for initialization
	void Start () {
        dir = 1;
        startpos = transform.position;
        endpos = startpos + movement;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(transform.position.z > endpos.z)
        {
            dir = 2;
        }
        else if(transform.position.z < startpos.z)
        {
            dir = 1;
        }

		if(dir == 1)
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + movement, speed * Time.deltaTime);
        }
        else if(dir == 2)
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - movement, speed * Time.deltaTime);
        }
	}
}
