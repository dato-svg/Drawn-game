using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStatsSound : MonoBehaviour
{
    public static int SoundVolume = 1;

    public void ChangeSoundVolume(int count = 1)
    {
        SoundVolume = count;
    }
}
