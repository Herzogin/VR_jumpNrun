using UnityEngine;
using Valve.VR;

public class SpeedBooster : MonoBehaviour
{
    public SteamVR_Action_Boolean Booster = null;
    public GameObject CameraRig;
    float lastSpeed;
    PlayerRun playerRun;

    private void Awake()
    {
        playerRun = CameraRig.GetComponent<PlayerRun>();
    }

    private void Update()
    {
        if (Booster.GetLastStateDown(SteamVR_Input_Sources.Any))
        {
            print("speed button pressed ");
            lastSpeed = playerRun.GetMovementSpeed();
            BoosteSpeed(lastSpeed);
        }
        else if (Booster.GetLastStateUp(SteamVR_Input_Sources.Any))
        {
            print("speed button released");
            playerRun.SetMovementSpeed(lastSpeed);
        }
    }

    private void BoosteSpeed(float oldSpeed)
    {
        if (oldSpeed <= 5.0f)
        {
            playerRun.SetMovementSpeed(oldSpeed * 20);
        }
        else if (oldSpeed >= 5.0f)
        {
            playerRun.SetMovementSpeed(oldSpeed * 10);
        }
        else if (oldSpeed >= 10.0f)
        {
            playerRun.SetMovementSpeed(oldSpeed * 5);
        }       
    }
}
