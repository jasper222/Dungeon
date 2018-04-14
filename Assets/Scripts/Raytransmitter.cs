using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raytransmitter : MonoBehaviour {

    public float Interval = 2f;
    public float range = 100f;

    float timer;
    Ray shootRay = new Ray();
    RaycastHit shootHit;
    int shootableMask;
    ParticleSystem gunParticles;
    LineRenderer gunLine;
    AudioSource gunAudio;
    float effectsDisplayTime = 0.2f;
    float camRayLength = 100f;

    // Use this for initialization
    void Start () {
        timer = 0f;
        gunLine = GetComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer>=Interval)
        {
            Shoot();
            timer = 0f;
        }
        if (timer>=Interval/2)
        {
            Aiming();
        }
        if (timer >=  effectsDisplayTime)
        {
            DisableEffects();
        }
    }
    void DisableEffects()
    {
        gunLine.enabled = false;
    }

    void Shoot()
    {
        gunLine.enabled = true;
        gunLine.SetPosition(0, transform.position);
        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;

        gunLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
    }

    void Aiming()
    {
        var colorbegin = Color.white;
        var colorend = new Color(1, timer / 2, 1, 0);
        gunLine.enabled = true;
        gunLine.SetPosition(0, transform.position);
        gunLine.startColor = colorbegin;
        gunLine.endColor = colorend;
        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;

        gunLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
    }
}
