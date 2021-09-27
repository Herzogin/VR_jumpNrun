using UnityEngine;
using Valve.VR.Extras;

public class shoot : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    void Awake()
    {
        laserPointer.PointerClick += PointerClick;
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
                FindObjectOfType<AudioManager>().PlayAudio("explosion");
                Destroy(e.target.gameObject);
                AmmunitionCounter.ammunition -= 1;
                CanvasChanger.changeAmmunitionText(AmmunitionCounter.ammunition);
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
