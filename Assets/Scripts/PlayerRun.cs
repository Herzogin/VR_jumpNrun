using UnityEngine;
using Valve.VR;

// inspired from: https://wirewhiz.com/how-to-implement-walking-and-jumping-in-unity-steamvr/

public class PlayerRun : MonoBehaviour
{
    private Vector2 trackpad;
    private Vector3 moveDirection;
    private CapsuleCollider CapCollider;

    public SteamVR_Input_Sources MovementHand;//Set Hand To Get Input From
    public SteamVR_Action_Boolean JumpAction;
    public float jumpHeight;
    public float MovementSpeed;
    public GameObject Head;
    public GameObject AxisHand;//Hand Controller GameObject

    private void Start()
    {
        CapCollider = GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        updateCollider();
        moveDirection = Head.transform.localRotation * Vector3.forward;
        Rigidbody RBody = GetComponent<Rigidbody>();
        Vector3 velocity = new Vector3(0, 0, 0);
        velocity = moveDirection;
        if (JumpAction.GetStateDown(MovementHand))
        {
            float jumpSpeed = Mathf.Sqrt(2 * jumpHeight * 9.81f);
            RBody.AddForce(0, jumpSpeed, 0, ForceMode.VelocityChange);
        }
        RBody.AddForce(velocity.x * MovementSpeed - RBody.velocity.x, 0, velocity.z * MovementSpeed - RBody.velocity.z, ForceMode.VelocityChange);
    }

    public float GetMovementSpeed()
    {
        return MovementSpeed;
    }

    public float GetJumpHeight()
    {
        return jumpHeight;
    }

    public void SetMovementSpeed(float speed)
    {
        MovementSpeed = speed;
    }

    public void SetJumpHeight(float height)
    {
        jumpHeight = height;
    }


    private void updateCollider()
    {
        CapCollider.height = Head.transform.localPosition.y;
        CapCollider.center = new Vector3(Head.transform.localPosition.x, Head.transform.localPosition.y / 2, Head.transform.localPosition.z);
    }
}