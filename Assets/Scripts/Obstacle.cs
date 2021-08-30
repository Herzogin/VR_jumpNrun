using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "[CameraRig]")
        {
            print("Kawumm!");
            LifeCounter.remainingLifes -= 1;
            //FindObjectOfType<AudioManager>().PlayAudio("BallCatch");
            Destroy(gameObject);
        }
    }
}
