using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newSong", menuName = "BeatGame/Songs")]
public class Songs : ScriptableObject
{
    public string songName;

    //certain songs are meant to played in certain maps: eg forest, sand, snow, etc.
    public string mapType;

    public AudioClip audioSong;

    public float bpm;
}
