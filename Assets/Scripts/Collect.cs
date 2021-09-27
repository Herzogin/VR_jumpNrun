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

            //colected item is ammunition:
            if(other.name == "gem_rose" || other.name == "Mushroom")
            {
                AmmunitionCounter.ammunition += 1;
                CanvasChanger.changeAmmunitionText(AmmunitionCounter.ammunition);
                Destroy(other.gameObject);
            }
            //collected item is loot:
            else if (other.name == "gem_white" || other.name == "Chicken")
            {
                LootCounter.lootCount += 1;
                CanvasChanger.changeLootCounterText(LootCounter.lootCount);
                other.GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
}
