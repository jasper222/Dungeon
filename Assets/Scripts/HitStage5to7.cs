using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStage5to7 : MonoBehaviour {
    public string Hitname;
    public int health;
    Rigidbody rig;
    

    public void Hitting()
    {
        if (Hitname == "Raytransmitter")
        {
            this.gameObject.SetActive(false);
            GameObject trigger = GameObject.Find("Bridge");

            Bridge bridge_s = trigger.GetComponent<Bridge>();
            bridge_s.Appear();

            GameObject raytrans_1 = GameObject.Find("Bullettransmitter_1");
            Raytransmitter ray = raytrans_1.GetComponent<Raytransmitter>();
            ray.model = 1;

            GameObject raytrans_2 = GameObject.Find("Bullettransmitter_2");
            Raytransmitter ray_2 = raytrans_2.GetComponent<Raytransmitter>();
            ray_2.model = 1;
        }
    }

    public void Enemy_hit()
    {
        Hitname = this.name;
        if (Hitname.Contains("enemy"))
        {
            health--;
        }
        if (health == 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
