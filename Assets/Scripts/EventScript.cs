using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EventScript
{
    public string name;
    public AudioClip audio;
    public float cooldown;
    public float activeTime;

    [HideInInspector]
    public AudioSource source;
}
