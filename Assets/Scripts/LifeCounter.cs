using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    public static int remainingLifes = 5;
    bool NoLifesLeft = false;
    
  

   

    void Update()
    {
        CanvasChanger.changeLifesText(remainingLifes);

        if (remainingLifes == 0 && !NoLifesLeft)
        {
            NoLifesLeft = true;
        }
    }

    
}
