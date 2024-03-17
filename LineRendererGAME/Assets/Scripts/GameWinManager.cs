using System;
using UI;
using UnityEngine;

public class GameWinManager : MonoBehaviour
{
    public static int CountIceTouch;
    private void Start()
    {
        CountIceTouch = 0;
    }
  
    public void IceTouch()
    {
        CountIceTouch++;
    }

  
}
