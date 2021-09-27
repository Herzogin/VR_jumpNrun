using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    public static int remainingLifes = 10;
    bool NoLifesLeft = false;

    void Update()
    {
        CanvasChanger.changeLifesText(remainingLifes);

        if (remainingLifes < 1)
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
