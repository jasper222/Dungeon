using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float jumpspeed;
    private Rigidbody rg3d;
    private Vector3 movement;
    private int GroundType = 1;
    //private ConstantForce constantforce;

    // Use this for initialization
    void Start()
    {
        movement = new Vector3(0f, 0f, 0f); 
        rg3d = GetComponent<Rigidbody>();
        //constantforce = GetComponent<ConstantForce>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GroundType == 1)
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");
            movement = new Vector3(moveX, 0f, moveZ);
            rg3d.AddForce(movement * speed);
        }
        else if (GroundType == 2)
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");
            movement = new Vector3(moveX, 0f, moveZ);
            rg3d.velocity = 2 * movement;
        }
        else if (GroundType == 3)
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");
            movement = new Vector3(-moveX, 0f, -moveZ);
            rg3d.AddForce(movement * speed);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            if(GroundType == 1 || GroundType == 2 || GroundType == 3)
            {
                rg3d.velocity = new Vector3(rg3d.velocity.x, jumpspeed + 0.0001f, rg3d.velocity.z);
            }
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            GroundType = 1;
        }
        else if(other.gameObject.CompareTag("GroundBlue"))
        {
            GroundType = 2;
        }
        else if (other.gameObject.CompareTag("GroundRed"))
        {
            GroundType = 3;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            GroundType = 0;
        }
        else if (other.gameObject.CompareTag("GroundBlue"))
        {
            GroundType = 0;
        }
        else if(other.gameObject.CompareTag("GroundRed"))
        {
            GroundType = 0;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("GameOver"))
        {
            GameObject gameoverUI = GameObject.Find("GameOverUI");
            Animator anim;
            anim = gameoverUI.GetComponent<Animator>();
            anim.SetTrigger("GameOverTrigger");
        }
    }


}
