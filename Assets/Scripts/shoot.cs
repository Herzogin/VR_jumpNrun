using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;

public class shoot : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    //GameObject sceneManager;




    void Awake()
    {
        //laserPointer.PointerIn += PointerInside;
        //laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    private void Start()
    {
        //sceneManager = GameObject.Find("SceneManager");
        //skyboxScript = GameObject.FindObjectOfType(typeof(SkyboxController)) as SkyboxController;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        Debug.Log("clicked");

        if (e.target.name == "Cube")
        {
            
            Debug.Log(e.target.name + " was clicked");
            Destroy(e.target.gameObject);
        }
    }
}
