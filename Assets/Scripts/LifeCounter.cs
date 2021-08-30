using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    public static int remainingLifes = 5;
    bool NoLifesLeft = false;
    public static int ammunition = 0;

   

    void Update()
    {
        if (remainingLifes == 0 && !NoLifesLeft)
        {
            NoLifesLeft = true;
        }
    }

    void OnGUI()
    {
        // style 
        GUIStyle fontStyle = new GUIStyle(GUI.skin.box);
        fontStyle.fontSize = 40;
        // font
        Font font = (Font)Resources.Load("Fonts/comic", typeof(Font));
        fontStyle.font = font;
        // color 
        fontStyle.normal.textColor = Color.white;
        // use style 
        GUI.Box(new Rect(20, 20, 200, 50), "Leben: " + remainingLifes.ToString(), fontStyle);
        GUI.Box(new Rect(20, 100, 200, 50), "Munition: " + ammunition.ToString(), fontStyle);
    }
}
