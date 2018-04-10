using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform Player;
    public float smoothing = 5f;

    Vector3 offset;

    void Start () {
        offset = transform.position - Player.position;
    }
	
	void FixedUpdate () {
        Vector3 targetCamPos = Player.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
