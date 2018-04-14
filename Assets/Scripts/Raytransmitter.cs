using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raytransmitter : MonoBehaviour {

    public float Interval = 2f;
    public float range = 100f;
    public Vector3 dir;
    public float speed;
    float timer;
    Ray shootRay = new Ray();
    RaycastHit shootHit;
    int shootableMask;
    LineRenderer gunLine;
    public float effectsDisplayTime = 0.2f;

    Rigidbody rig;

    // Use this for initialization
    void Start () {
        timer = 0f;
        gunLine = GetComponent<LineRenderer>();
        shootableMask = LayerMask.GetMask("Default");
        gunLine.SetColors(Color.black, Color.yellow);


    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer>=Interval)
        {
            gunLine.enabled = false;
            Shoot();
            DisableEffects();
        }
        else if (timer>=Interval/2)
        {
            gunLine.enabled = false;
            Aiming();
        }
    }
    void DisableEffects()
    {
        gunLine.enabled = false;
        timer = 0f;
    }

    void Shoot()
    {
        Object Bullet = Resources.Load("Perfabs/Bullet", typeof(GameObject));
        GameObject bullet = Instantiate(Bullet) as GameObject;
        bullet.transform.position = transform.position;
        bullet.name = "bullet_1";
        rig = bullet.GetComponent<Rigidbody>();
        rig.velocity = dir * speed;

    }

    void Aiming()
    {
        var colorbegin = Color.white;
        var colorend = new Color(1, timer / 2, 1, 1);

        
        gunLine.enabled = true;
        gunLine.SetPosition(0, transform.position);
        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;
        if (Physics.Raycast(shootRay, out shootHit, range, shootableMask))
        {

            gunLine.SetPosition(1, shootHit.point);

        }
        else
        {

            gunLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
        }

    }
}
