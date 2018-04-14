using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Global : MonoBehaviour {
    public Vector3 point;
   
	// Use this for initialization
	void Start ()
    {
        LoadPlayer();
        if (SceneManager.GetActiveScene().name == "Stage4")
        {
            ItemManage.LoadItemStage4();
        }
    }

    void LoadPlayer()
    {
        Object playerperfab = Resources.Load("Perfabs/Player", typeof(GameObject));
        GameObject player = Instantiate(playerperfab) as GameObject;
        player.transform.position = point;
        player.name = "Player";
    }
	
}
