using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCamera : MonoBehaviour {

    // Use this for initialization
    public GameObject[] cameras;
    public string[] shotcuts;
    public bool changeAudioListener = true;
    private int cflag = 0;

    private void Start()
    {
        cameras[1].GetComponent<AudioListener>().enabled = false;
        cameras[1].GetComponent<Camera>().enabled = false;
    }
    void Update()
    {
        
        if (Input.GetKeyUp("q"))
            SwitchCamera();
    }

    void SwitchCamera()
    {
        cameras[cflag].GetComponent<AudioListener>().enabled = false;
        cameras[cflag].GetComponent<Camera>().enabled = false;
        cflag = 1 - cflag;
        cameras[cflag].GetComponent<AudioListener>().enabled = true;
        cameras[cflag].GetComponent<Camera>().enabled = true;
        
    }
}
