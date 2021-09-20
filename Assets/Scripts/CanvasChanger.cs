using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasChanger : MonoBehaviour
{
    public GameObject Lifes = null;
    public GameObject Ammunition = null;
    public GameObject Loot = null;

    private static  Text LifeText;
    private static Text AmmunitionText;
    private static Text LootText;


    //Start is called before the first frame update
    void Start()
    {
        LifeText = Lifes.GetComponent<Text>();
        AmmunitionText = Ammunition.GetComponent<Text>();
        LootText = Loot.GetComponent<Text>();
    }

    public static void changeLifesText(int LifeCount)
    {
        LifeText.text = LifeCount.ToString();
    }

    public static void changeAmmunitionText(int AmmunitionCounter)
    {
        AmmunitionText.text = AmmunitionCounter.ToString();
    }

    public static void changeLootCounterText(int LootCounter)
    {
        LootText.text = LootCounter.ToString();
    }

}
