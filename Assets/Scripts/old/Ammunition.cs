using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Quelle: https://www.youtube.com/watch?v=ryfUXr5yvKw


[RequireComponent(typeof(Rigidbody))]
public class Ammunition : MonoBehaviour
{
    [HideInInspector]
    public Hand activeHand = null;
}
