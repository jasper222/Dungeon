using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBridge : MonoBehaviour {

    public float speed = 20f;
    public Vector3 dir;

	void FixedUpdate () {
        transform.Rotate(dir, speed * Time.deltaTime);
    }
}
