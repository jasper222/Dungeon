using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private int live = 1;
    private float timer = 0.3f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (live==0)
        {
            timer -= Time.deltaTime;
        }
        if (timer<=0)
        {
            this.gameObject.SetActive(false);
            Destroy(this, Time.deltaTime);
        }
        //timer -= Time.deltaTime;
        //if (timer<=0)
        //{
        //    this.gameObject.SetActive(false);
        //    Destroy(this);
        //}
	}
    void OnCollisionEnter(Collision collision)
    {
        live = 0;

    }

    public void Destroyself(float t)
    {

        Destroy(this, t);
    }
}
