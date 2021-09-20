using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmunitionCounter : MonoBehaviour
{
    public static int ammunition = 0;
    public static bool ammunitionLeft = false;
  
    // Update is called once per frame
    void Update()
    {
        if (ammunition == 0)
        {
            ammunitionLeft = false;

        }else if (ammunition > 0)
        {
            ammunitionLeft = true;
        }
    }


}
