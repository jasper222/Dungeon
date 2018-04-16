using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage6SurfaceCube : MonoBehaviour {

    private GameObject followObject;

	void Start () {
        followObject = GameObject.Find("Rg3DCube");
    }
	
	void Update () {
		if(followObject == null)
        {
            followObject = GameObject.Find("Rg3DCube");
        }
        else
        {
            transform.position = followObject.transform.position + new Vector3(0f, 2.05f, 0f);
        }
	}
}
