using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject healthpoint = GameObject.Find("HealthPoint");
        healthpoint.GetComponent<Text>().text = HealthManage.PlayerHealth.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
