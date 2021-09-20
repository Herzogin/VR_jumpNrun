using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreAmmuMoreSpeed : MonoBehaviour
{
    public GameObject CameraRig = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(AmmunitionCounter.ammunition > 2)
        {
            CameraRig.GetComponent<PlayerRun>().SetMovementSpeed(8);
        }
        else if(AmmunitionCounter.ammunition <= 2)
        {
            CameraRig.GetComponent<PlayerRun>().SetMovementSpeed(4);
        }
    }
}
