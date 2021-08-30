using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasChanger : MonoBehaviour
{
    private static  Text LifeText;
    private static Text AmmunitionText;
    

    // Start is called before the first frame update
    void Start()
    {
        LifeText = GameObject.Find("/Canvas/Lifes").GetComponent<Text>();
        AmmunitionText = GameObject.Find("/Canvas/Ammunition").GetComponent<Text>();
    }

    public static void changeLifesText(int LifeCount)
    {
        LifeText.text = LifeCount.ToString();
    }

    public static void changeAmmunitionText(int AmmunitionCounter)
    {
        AmmunitionText.text = AmmunitionCounter.ToString();
    }
}
