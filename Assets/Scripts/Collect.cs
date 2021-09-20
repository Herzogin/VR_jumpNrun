using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        print("entered: " + other.name);
        if (other.gameObject.CompareTag("Collectable"))
        {
            print("collected " + other.name);
            FindObjectOfType<AudioManager>().PlayAudio("pickup1");

            if(other.name == "gem_rose" || other.name == "Sphere")
            {
                AmmunitionCounter.ammunition += 1;
                CanvasChanger.changeAmmunitionText(AmmunitionCounter.ammunition);
                Destroy(other);
            }
            else if (other.name == "gem_white" || other.name == "Chicken" || other.name == "Sphere")
            {
                LootCounter.lootCount += 1;
                //CanvasChanger.changeGemCounterText(GemCounter.gem_white);
                CanvasChanger.changeLootCounterText(LootCounter.lootCount);
                Destroy(other);
            }
            //else if()
            //{
            //    ChickenCounter.chicken += 1;
            //}

        }
    }

    private void OnTriggerExit(Collider other)
    {
        //if (other.gameObject.CompareTag("Collectable"))
        //{
        //    Destroy(other);
        //}
    }
}
