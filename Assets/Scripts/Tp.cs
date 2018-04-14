using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp : MonoBehaviour {
    public string loadName;
    public string NextStage;
	
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ItemManage.PassOrReStart = true;
            SceneManager.LoadSceneAsync(NextStage);
        }
    }
}
