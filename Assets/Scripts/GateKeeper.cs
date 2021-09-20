using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GateKeeper : MonoBehaviour
{
    public GameObject CameraRig = null;
    public GameObject Canvas = null;
    public GameObject CanvasCounter = null;
    public GameObject lootTextObject = null;

    private static Text LootText;

    //Start is called before the first frame update
    void Start()
    {
        LootText = lootTextObject.GetComponent<Text>();
    }

    private void OnTriggerEnter(Collider other)
    {
        CameraRig.GetComponent<PlayerRun>().SetMovementSpeed(0);
        Canvas.SetActive(false);
        CanvasCounter.SetActive(true);
        
        LootText.text = LootCounter.lootCount.ToString();

        if (LootCounter.lootCount > 20)
        {
            CanvasCounter.transform.GetChild(2).gameObject.SetActive(true);
            CameraRig.GetComponent<PlayerRun>().SetMovementSpeed(0.3f);
        }
        else
        {
            CanvasCounter.transform.GetChild(3).gameObject.SetActive(true);
        }
    }
}
