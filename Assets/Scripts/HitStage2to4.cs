using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStage2to4 : MonoBehaviour {
    public string Hitname;
    public int health;
    Rigidbody rig;

    public void Hitting()
    {
        if (Hitname == "Attacker_2_1")
        {
            Object playerperfab_1 = Resources.Load("Perfabs/Enemy", typeof(GameObject));
            GameObject enemy_1 = Instantiate(playerperfab_1) as GameObject;
            enemy_1.transform.position = new Vector3(29f, 3.5f, 20f);
            enemy_1.name = "enemy_1";
            enemy_1.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            rig = enemy_1.GetComponent<Rigidbody>();
            rig.velocity = new Vector3(0, 0, -5);

            Object playerperfab_2 = Resources.Load("Perfabs/Enemy", typeof(GameObject));
            GameObject enemy_2 = Instantiate(playerperfab_2) as GameObject;
            enemy_2.transform.position = new Vector3(31f, 3.5f, 20f);
            enemy_2.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            enemy_2.name = "enemy_2";
            rig = enemy_2.GetComponent<Rigidbody>();
            rig.velocity = new Vector3(0, 0, -5);

            GameObject obj = GameObject.Find("Gate");
            Bridge bridge_s = obj.GetComponent<Bridge>();
            bridge_s.Appear();
            this.gameObject.SetActive(false);

            GameObject disappear = GameObject.Find("stone_3");
            disappear.SetActive(false);
        }
        if (Hitname == "Bridge1")
        {
            GameObject trigger = GameObject.Find(Hitname);
            Bridge bridge = trigger.GetComponent<Bridge>();
            bridge.Appear();
            this.gameObject.SetActive(false);
        }
    }

    public void Enemy_hit()
    {
        Hitname = this.name;
        if (Hitname.Contains("enemy"))
        {
            health--;
        }
        if (health==0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
