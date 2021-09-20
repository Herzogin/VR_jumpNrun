using System;
using UnityEngine;
using UnityEngine.Events;

//Quellen: 
//https://www.youtube.com/watch?v=CPyaWkjo6Ss
//https://www.youtube.com/watch?v=2SpegTl1wP8
//https://www.youtube.com/watch?v=C7Lo3VoMHn0

[Serializable]
public class RadialSection
{
    public Sprite icon = null;
    public SpriteRenderer iconRenderer = null;
    public UnityEvent onPress = new UnityEvent();
}
