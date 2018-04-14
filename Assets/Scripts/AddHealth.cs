using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddHealth : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        HealthManage.PlayerHealth++;
        this.gameObject.SetActive(false);
        GameObject healthpoint = GameObject.Find("HealthPoint");
        healthpoint.GetComponent<Text>().text = "× " + HealthManage.PlayerHealth.ToString();
    }
}
