using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour {

    public Vector3 CatapultSpeed;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody playerRg3d;
        playerRg3d = collision.gameObject.GetComponent<Rigidbody>();
        playerRg3d.velocity += CatapultSpeed;
    }
}
