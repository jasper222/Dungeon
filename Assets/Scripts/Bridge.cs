using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour {
    private int locks = 0;
    public Vector3 targetpos;
    public Vector3 startpos;
    public float smoothing;
    // Use this for initialization
    void Start () {
        transform.position = startpos;
    }
	
	// Update is called once per frame
	void FixedUpdate()
    {
        if (locks==1)
        {
            Vector3 vec = targetpos;
            transform.position = Vector3.Lerp(transform.position, vec, smoothing * Time.deltaTime);
        }
        
    }
    public void Appear()
    {
        locks = 1;
    }
}
