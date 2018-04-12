using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Globe
{
    //在这里记录当前切换场景的名称
    public static string loadName;
}
public class Tp : MonoBehaviour {

    public GameObject player;
    public string NextStage;

    void Start () {
        //DontDestroyOnLoad(player);
        GameObject ui = GameObject.Find("MessageUI");
        DontDestroyOnLoad(ui);

    }
	

	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync(NextStage);
            
        }
    }
}
