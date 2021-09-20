using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStarts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().PlayAudio("AudioOnStart");
    }

}
