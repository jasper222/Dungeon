using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterSysTrigger : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            RotatingOrb.count++;
            RotatingOrb.RotateController = true;
        }
    }
}
