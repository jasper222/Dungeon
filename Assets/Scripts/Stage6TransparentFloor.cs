using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage6TransparentFloor : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GameObject RaytransmitterFire = GameObject.Find("RaytransmitterFire");
            Raytransmitter raytransmitter = RaytransmitterFire.GetComponent<Raytransmitter>();
            raytransmitter.enabled = true;
        }
    }
}
