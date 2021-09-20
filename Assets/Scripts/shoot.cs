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
        
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        Debug.Log("clicked");
        Debug.Log("AmmunitionLeft: " + AmmunitionCounter.ammunitionLeft);
        FindObjectOfType<AudioManager>().PlayAudio("shoot");
        if (e.target.tag == "Shootable")
        {
            if (AmmunitionCounter.ammunitionLeft)
            {
                //Debug.Log(e.target.name + " was clicked");
                FindObjectOfType<AudioManager>().PlayAudio("explosion");
                Destroy(e.target.gameObject);
                AmmunitionCounter.ammunition -= 1;
            }
        }else if (e.target.tag == "NotShootable")
        {
            FindObjectOfType<AudioManager>().PlayAudio("hitMiss");
            if(e.target.gameObject.transform.localScale.x < 6)
            {
                e.target.gameObject.transform.localScale *= 1.5f; 
            }
            
        }
    }
}
