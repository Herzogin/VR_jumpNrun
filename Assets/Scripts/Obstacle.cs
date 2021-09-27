using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "[CameraRig]")
        {
            print("collision with obstacle!!");
            LifeCounter.remainingLifes -= 1;
            FindObjectOfType<AudioManager>().PlayAudio("explosion");
            Destroy(gameObject);
        }
    }
}
