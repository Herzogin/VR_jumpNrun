using UnityEngine;
using Valve.VR;

public class HitDestroy : MonoBehaviour
{
    public SteamVR_Action_Boolean Smash = null;
    public GameObject ControllerLeft = null;
    public GameObject ControllerRight = null;
    bool gripPressed = false;

    
    // Update is called once per frame
    private void Update()
    {
        if (Smash.GetLastStateDown(SteamVR_Input_Sources.Any))
        {
            print("Grip pressed " + gripPressed);
            gripPressed = true;

            if (Smash.GetLastStateDown(SteamVR_Input_Sources.RightHand))
            {
                ControllerRight.transform.GetChild(0).gameObject.SetActive(false);
                ControllerRight.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (Smash.GetLastStateDown(SteamVR_Input_Sources.LeftHand))
            {
                ControllerLeft.transform.GetChild(0).gameObject.SetActive(false);
                ControllerLeft.transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        else if (Smash.GetLastStateUp(SteamVR_Input_Sources.Any))
        {
            print("Grip pressed " + gripPressed);
            gripPressed = false;

            if (Smash.GetLastStateUp(SteamVR_Input_Sources.RightHand))
            {
                ControllerRight.transform.GetChild(0).gameObject.SetActive(true);
                ControllerRight.transform.GetChild(1).gameObject.SetActive(false);
            }
            else if (Smash.GetLastStateUp(SteamVR_Input_Sources.LeftHand))
            {
                ControllerLeft.transform.GetChild(0).gameObject.SetActive(true);
                ControllerLeft.transform.GetChild(1).gameObject.SetActive(false);
            }          
        }   
    }


    private void OnTriggerEnter(Collider other)
    {
        print("entered: " + other.name);
        if (gripPressed & other.gameObject.CompareTag("Smashable"))
        {
            print("smashed " + other.name);
            FindObjectOfType<AudioManager>().PlayAudio("woodHit");
            Destroy(other.gameObject);
        }
    }
}
