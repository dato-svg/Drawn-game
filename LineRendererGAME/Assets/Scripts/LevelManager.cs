using System;
using DefaultNamespace;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject levelLocked;
    [SerializeField] private GameObject starsObject;
    [SerializeField] private GameObject star1;
    [SerializeField] private GameObject star2;
    [SerializeField] private GameObject star3;

    public  string KEY;
    public int StarSI;
    int num;


    private void Awake()
    {
        for (int i = 1; i <  StaticStartsData.isOpen.Length; i++)
        {
            string key = $"isOpen1{i}";
            StaticStartsData.isOpen[i] =  PlayerPrefs.GetInt(key);
            Debug.Log(key + StaticStartsData.isOpen[i] );
        }
        
        
        for (int i = 1; i <  StaticStartsData.starCount.Length; i++)
        {
            string key = $"starCount1{i}";
            StaticStartsData.starCount[i] =  PlayerPrefs.GetInt(key);
            Debug.Log(key + StaticStartsData.starCount[i]);
        }
        
        Stats.Stars =  PlayerPrefs.GetInt("AllStar");
    }  


    private void Start()
    {
        
        Debug.Log(StarSI);
        KEY = gameObject.name;
        levelLocked = gameObject.transform.GetChild(1).gameObject;
        starsObject = gameObject.transform.GetChild(2).gameObject;
        star1 = starsObject.transform.GetChild(0).GetChild(0).gameObject;
        star2 = starsObject.transform.GetChild(1).GetChild(0).gameObject;
        star3 = starsObject.transform.GetChild(2).GetChild(0).gameObject;
        StaticStartsData.isOpen[1] = 1;
            
        
        
        for (int i = 1; i < StaticStartsData.starCount.Length; i++)
        {
            if( KEY == "Level"+i)
            {
                num = i;
                StarSI = StaticStartsData.starCount[i];
                
            }
        }
        
        
        if (StaticStartsData.isOpen[num] == 0)
        {
            levelLocked.SetActive(true);
            starsObject.SetActive(false);
           
            
        }
        if(StaticStartsData.isOpen[num] == 1)
        {
            levelLocked.SetActive(false);
            starsObject.SetActive(true);

            if (StarSI == 0)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
                
            }
            
            if (StarSI  == 1)
            {
                star1.SetActive(true);
                star2.SetActive(false);
                star3.SetActive(false);
            }
            if (StarSI == 2)
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(false);
            }
            
            if (StarSI  == 3)
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
            }
        }

        
    }
    
}
