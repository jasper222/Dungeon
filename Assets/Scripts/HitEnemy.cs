using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour {
    public int health;

    public void Enemy_hit()
    {
        string Hitname = this.name;
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
