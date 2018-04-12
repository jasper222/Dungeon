using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour {
    public Vector3 point;
   
	// Use this for initialization
	void Start () {
        Object playerperfab = Resources.Load("Perfabs/Player", typeof(GameObject));
        GameObject player = Instantiate(playerperfab) as GameObject;
        player.transform.position = point;
        player.name = "Player";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
