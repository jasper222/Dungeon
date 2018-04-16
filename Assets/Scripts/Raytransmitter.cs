using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raytransmitter : MonoBehaviour {

    public float Interval = 2f;
    public float OpenRay;
    public float range = 100f;
    public int rotate=0;
    public Vector3 dir;
    public float speed;
    public int model;
    float timer;
    int flag=0;
    Ray shootRay = new Ray();
    RaycastHit shootHit;
    int shootableMask;
    LineRenderer gunLine;
    public float delaytime = 0;

    Rigidbody rig;

    // Use this for initialization
    void Start () {
        timer = -delaytime;
        gunLine = GetComponent<LineRenderer>();
        shootableMask = LayerMask.GetMask("Default");

    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (flag==1)
        {
            if (timer>= Interval)
            {
                flag = 0;
                timer = 0;
            }
        }
        if (timer>= Interval && model==1)
        {
            Shoot();
            DisableEffects();
        }
        if (timer >= OpenRay && model == 3)
        {
            Shoot2();
            DisableEffects();
        }
        if (model==0 && flag==0 && timer>=0)
        {
            Aiming();
        }
        if (timer>= OpenRay && model==0)
        {
            DisableEffects();
        }
        if(model == 2)
        {
            Aiming();
        }
    }
    void DisableEffects()
    {
        gunLine.enabled = false;
        timer = 0f;
        flag = 1;
    }

    void Shoot()
    {
        Object Bullet = Resources.Load("Perfabs/Bullet", typeof(GameObject));
        GameObject bullet = Instantiate(Bullet) as GameObject;
        bullet.AddComponent<Bullet>();
        bullet.transform.position = transform.position + dir.normalized * 1.5f;
        bullet.name = "bullet_1";
        rig = bullet.GetComponent<Rigidbody>();
        rig.velocity = dir * speed;
        Bullet obj = bullet.GetComponent<Bullet>();
        obj.Destroyself(5);

    }

    void Shoot2()
    {
        Object Bullet = Resources.Load("Perfabs/Bullet2", typeof(GameObject));
        GameObject bullet = Instantiate(Bullet) as GameObject;
        bullet.AddComponent<Bullet>();
        bullet.transform.position = transform.position;
        bullet.name = "bullet_2";
        rig = bullet.GetComponent<Rigidbody>();
        rig.velocity = dir * speed;
        Bullet obj = bullet.GetComponent<Bullet>();
        obj.Destroyself(5);

    }

    void Aiming()
    {
        gunLine.enabled = true;
        gunLine.SetPosition(0, transform.position);
        shootRay.origin = transform.position;
        if (rotate==0)
            shootRay.direction = dir;
        else
            shootRay.direction = transform.forward;
        if (Physics.Raycast(shootRay, out shootHit, range, shootableMask))
        {

            gunLine.SetPosition(1, shootHit.point);
            if (shootHit.collider.CompareTag("Player"))
            {
                PlayerMovement obj = shootHit.collider.GetComponent<PlayerMovement>();
                obj.PlayerDie();
            }
        }
        else
        {

            gunLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
        }

    }
}
