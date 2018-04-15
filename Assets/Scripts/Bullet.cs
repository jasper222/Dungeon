using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private float timer = 1f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //timer -= Time.deltaTime;
        //if (timer<=0)
        //{
        //    this.gameObject.SetActive(false);
        //    Destroy(this);
        //}
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            Destroy(this);
        }
    }
    public void Destroyself(float t)
    {
        Destroy(this, t);
    }
}
