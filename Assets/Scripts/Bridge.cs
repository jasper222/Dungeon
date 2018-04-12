using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour {
    GameObject bridge;
    private int locks = 0;
    private float dis = 0;
    public Vector3 targetpos;
    public float smoothing;
    // Use this for initialization
    void Start () {
        bridge = GameObject.Find("Bridge");
        bridge.transform.Translate(0, -10, 0);
    }
	
	// Update is called once per frame
	void FixedUpdate()
    {
        if (locks==1)
        {
            Vector3 vec = targetpos - bridge.transform.position;
            bridge.transform.position = Vector3.Lerp(bridge.transform.position, vec, smoothing * Time.deltaTime);
            
        }
        
    }
    public void Appear()
    {
        locks = 1;
    }
}
