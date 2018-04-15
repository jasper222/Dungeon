using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private GameObject Player;
    public float smoothing = 5f;

    public Vector3 offset = new Vector3(-0.8f, 9f, -5f);

    void Start () {
        Player = GameObject.Find("Player");
    }
	
	void FixedUpdate () {
        if(Player == null) Player = GameObject.Find("Player");
        Vector3 targetCamPos = Player.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
