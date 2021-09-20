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

        if (remainingLifes < 1) //== 0 && !NoLifesLeft)
        {
            NoLifesLeft = true;
        }

        if (NoLifesLeft)
        {
            FindObjectOfType<SceneSwitch>().switchToScene("GameOver0");
        }
    }

    public void SetRemainingLifes(int lifes)
    {
        remainingLifes = lifes;
    }
}
