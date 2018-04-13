using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public float timeBetweenBullets = 0.15f;
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

    void Awake()
    {
        shootableMask = LayerMask.GetMask("Default");
        gunParticles = GetComponent<ParticleSystem>();
        gunLine = GetComponent<LineRenderer>();
        gunAudio = GetComponent<AudioSource>();
    }

    void Update () {
        timer += Time.deltaTime;

        if (Input.GetButton("Fire1") && timer >= timeBetweenBullets && Time.timeScale != 0)
        {
            Shoot();
        }

        if (timer >= timeBetweenBullets * effectsDisplayTime)
        {
            DisableEffects();
        }
    }

    public void DisableEffects()
    {
        gunLine.enabled = false;
    }


    void Shoot()
    {
        Turning();

        timer = 0f;

        gunAudio.Play();

        gunParticles.Stop();
        gunParticles.Play();

        gunLine.enabled = true;
        gunLine.SetPosition(0, transform.position);

        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;

        if (Physics.Raycast(shootRay, out shootHit, range, shootableMask))
        {
           
            gunLine.SetPosition(1, shootHit.point);
            if (shootHit.collider.CompareTag("Hit"))
            {
                if(SceneManager.GetActiveScene().name == "Stage2" || SceneManager.GetActiveScene().name == "Stage3")
                {
                    HitStage2to4 obj = shootHit.collider.GetComponent<HitStage2to4>();
                    obj.Hitting();
                } 
            }
            if (shootHit.collider.name.Contains("enemy"))
            {
                if(SceneManager.GetActiveScene().name == "Stage2" || SceneManager.GetActiveScene().name == "Stage3")
                {
                    HitStage2to4 obj = shootHit.collider.GetComponent<HitStage2to4>();
                    obj.Enemy_hit();
                }
                
            }
           
            
        }
        else
        {
            gunLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
        }
    }

    void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;

        if(Physics.Raycast(camRay, out floorHit, camRayLength, shootableMask))
        {
            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 0f;
            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            transform.rotation = newRotation;
        }
    }
}
