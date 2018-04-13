using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovingZ : MonoBehaviour {

    public Vector3 movement;
    public float speed = 1f;
    private Vector3 startpos;
    private Vector3 endpos;
    private int dir;
    private Rigidbody rg3d;
	// Use this for initialization
	void Start () {
        dir = 1;
        rg3d = GetComponent<Rigidbody>();
        rg3d.velocity = movement;
        startpos = transform.position;
        endpos = startpos + movement;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(movement.z > 0f)
        {
            if (transform.position.z > endpos.z)
            {
                dir = 2;
            }
            else if (transform.position.z < startpos.z)
            {
                dir = 1;
            }
        }
        else if(movement.z < 0f)
        {
            if (transform.position.z < endpos.z)
            {
                dir = 2;
            }
            else if (transform.position.z > startpos.z)
            {
                dir = 1;
            }
        }
        if (dir == 1)
        {
            rg3d.velocity = movement / movement.z * speed;
        }
        else if (dir == 2)
        {
            rg3d.velocity = - movement / movement.z * speed;
        }
    }
}
