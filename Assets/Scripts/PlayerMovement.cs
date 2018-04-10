using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float jumpspeed;
    private Rigidbody rg3d;
    private ConstantForce constantforce;

    // Use this for initialization
    void Start()
    {
        rg3d = GetComponent<Rigidbody>();
        constantforce = GetComponent<ConstantForce>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveX, 0f, moveZ);
        rg3d.AddForce(movement * speed);

        if (Input.GetKey(KeyCode.Space))
        {
            if(rg3d.velocity.y == 0f)
            {
                rg3d.velocity = new Vector3(0f, jumpspeed + 0.0001f, 0f);
            }
        }
    }
}
