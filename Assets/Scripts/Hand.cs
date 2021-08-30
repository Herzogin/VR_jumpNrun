using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

//Quelle 1: https://www.youtube.com/watch?v=HnzmnSqE-Bc
//Quelle 2: https://www.youtube.com/watch?v=ryfUXr5yvKw

public class Hand : MonoBehaviour
{
    public SteamVR_Action_Boolean Grab = null;

    private SteamVR_Behaviour_Pose Pose = null;
    private FixedJoint Joint = null;
    GameObject currentCollectableItem = null;

    // Start is called before the first frame update
    private void Awake()
    {
        Pose = GetComponent<SteamVR_Behaviour_Pose>();
        Joint = GetComponent<FixedJoint>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Down
        if (Grab.GetLastStateDown(Pose.inputSource))
        {
            print("Trigger down " + Pose.inputSource);
            Collect();
        }

        //Up
        //if (Grab.GetLastStateUp(Pose.inputSource))
        //{
        //    print("Trigger up " + Pose.inputSource);
        //    Drop();
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        currentCollectableItem = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        currentCollectableItem = null;
    }

    public void Collect()
    {
        if (!currentCollectableItem)
        {
            print("No collectable Item selected");
            return;
        }
        else if(currentCollectableItem)
        {
            AmmunitionCounter.ammunition += 1;
            FindObjectOfType<AudioManager>().PlayAudio("pickup1");
            Destroy(currentCollectableItem);
        }


        //position
        currentCollectableItem.transform.position = transform.position;

        //attach
        Rigidbody targetBody = currentCollectableItem.GetComponent<Rigidbody>(); 
        
    }

    //public void Drop()
    //{
        
    //}

    
}
