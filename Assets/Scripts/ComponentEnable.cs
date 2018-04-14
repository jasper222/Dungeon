using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentEnable : MonoBehaviour {

    private bool LockKey = false;
    
    
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		if(LockKey)
        {
            PlatformMovingZ script;
            script = GetComponent<PlatformMovingZ>();
            script.enabled = true;
        }
	}

    public void UnLock()
    {
        LockKey = true;
    }
}
