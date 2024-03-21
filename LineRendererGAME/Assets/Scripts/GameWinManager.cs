using System;
using UI;
using UnityEngine;

public class GameWinManager : MonoBehaviour
{
    [SerializeField] private GameObject[] iceBlock;
    
    public static int CountIceTouch;
    private void Start()
    {
        CountIceTouch = 0;
    }
  
    public void IceTouch()
    {
        CountIceTouch++;
    }

    public void Update()
    {
        for (int i = 0; i < CountIceTouch; i++)
        {
            iceBlock[i].SetActive(true);
        }
    }
}
