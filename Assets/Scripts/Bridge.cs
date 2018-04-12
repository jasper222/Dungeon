using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour {
    GameObject bridge;
    private int locks = 0;
    private float dis = 0;
    // Use this for initialization
    void Start () {
        bridge = GameObject.Find("Bridge");
        bridge.transform.Translate(0, -10, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (locks==1)
        {
            Vector3 nor = new Vector3(0, 1, 0);
            bridge.transform.Translate(nor * Time.deltaTime*3);
            dis += Time.deltaTime*3;
            if (dis>10)
            {
                locks = 0;
            }
        }
        
    }
    public void Appear()
    {
        locks = 1;
    }
}
