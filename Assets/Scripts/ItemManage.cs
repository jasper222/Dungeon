using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManage : MonoBehaviour {

    public static bool PassOrReStart = true;

    public static void LoadItemStage4()
    {
        Object HealthBox = Resources.Load("Perfabs/HealthBox", typeof(GameObject));
        GameObject healthbox = Instantiate(HealthBox) as GameObject;
        healthbox.transform.position = new Vector3(28f, 18f, 21f);
    }
}
