
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMoving : MonoBehaviour {

    public Vector3 strartpos;
    public Vector3 endpos;
    public float speed;
    Vector3 dir;
    private int flag = 0;
    private float distance = 0;
    private float len;
    // Use this for initialization
    void Start () {
        transform.position = strartpos;
        dir = endpos - strartpos;
        len = dir.magnitude;
        dir.Normalize();
        
    }
	
	// Update is called once per frame
	void FixedUpdate() {
        if (distance>=len)
        {
            flag = 1 - flag;
            distance = 0;
        }
        if (flag==0)
        {
            transform.Translate(dir * Time.deltaTime * speed);
            distance += Time.deltaTime * speed;
        }
        if (flag==1)
        {
            transform.Translate(-dir * Time.deltaTime * speed);
            distance += Time.deltaTime * speed;
        }
    }
}
