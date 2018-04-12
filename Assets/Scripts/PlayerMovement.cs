using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float jumpspeed;
    private Rigidbody rg3d;
    private Vector3 movement;
    private bool isOnGround = true;
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
        if(isOnGround)
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");
            movement = new Vector3(moveX, 0f, moveZ);
            rg3d.AddForce(movement * speed);
        }
        

        if (Input.GetKey(KeyCode.Space))
        {
            if(isOnGround)
            {
                rg3d.velocity = new Vector3(rg3d.velocity.x, jumpspeed + 0.0001f, rg3d.velocity.z);
            }
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isOnGround = false;
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
