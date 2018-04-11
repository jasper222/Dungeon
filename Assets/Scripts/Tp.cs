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
    //public GameObject  camera;
    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(player);
        GameObject ui = GameObject.Find("MessageUI");
        DontDestroyOnLoad(ui);
        //DontDestroyOnLoad(camera);
        //Object[] initsObjects = GameObject.FindObjectsOfType(typeof(GameObject));
        //foreach (Object go in initsObjects)
        //{
        //    DontDestroyOnLoad(go);
        //}
    }
	
	// Update is called once per frame
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
