using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCamera : MonoBehaviour {

    private GameObject Player;
    public float smoothing = 5f;

    public Vector3 offset = new Vector3(-2f, 24f, -11f);

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        if (Player == null) Player = GameObject.Find("Player");
        Vector3 targetCamPos = Player.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
