using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoving : MonoBehaviour {

    public Vector3 movement;
    public float speed = 5f;
    private Vector3 startpos;
    private int dir;
	// Use this for initialization
	void Start () {
        dir = 1;
        startpos = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(transform.position ==  startpos + movement)
        {
            dir = 2;
        }
        else if(transform.position == startpos)
        {
            dir = 1;
        }

		if(dir == 1)
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + movement, speed * Time.deltaTime);
        }
        else if(dir == 2)
        {
            transform.position = Vector3.Lerp(transform.position, startpos, speed * Time.deltaTime);
        }
	}
}
