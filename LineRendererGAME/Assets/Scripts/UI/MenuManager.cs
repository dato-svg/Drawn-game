using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class MenuManager : MonoBehaviour
    {
        public int starCount;
        [SerializeField] private Animator animatorMenu;
        private static readonly int One = Animator.StringToHash("One");
        private static readonly int Two = Animator.StringToHash("Two");
        private static readonly int Three = Animator.StringToHash("Three");
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private bool education = false;
        private void Start()
        {

            _audioSource = GetComponent<AudioSource>();
            animatorMenu = GetComponent<Animator>();
            _audioSource.Play();
            if (GameWinManager.CountIceTouch <= 2)
            {
                animatorMenu.SetTrigger(One);
                Stats.Stars += 1;
                starCount = 1;
                Debug.Log(starCount);
            }
            else if (GameWinManager.CountIceTouch >= 3 && GameWinManager.CountIceTouch < 5)
            {
                animatorMenu.SetTrigger(Two);
                Stats.Stars += 2;
                starCount = 2;
                Debug.Log(starCount);
            }
            else if (GameWinManager.CountIceTouch >= 5)
            {
                animatorMenu.SetTrigger(Three);
                Stats.Stars += 3;
                starCount = 3;
                Debug.Log(starCount);
            }

            if (education)
            {
                return;
            }
            StaticStartsData.starCount[SceneManager.GetActiveScene().buildIndex - 2] = starCount;
            StaticStartsData.isOpen[SceneManager.GetActiveScene().buildIndex - 1] = 1;

            for (int i = 0; i < StaticStartsData.isOpen.Length; i++)
            {
                string key = $"isOpen1{i}";
                PlayerPrefs.SetInt(key, StaticStartsData.isOpen[i]);
                Debug.Log(key + StaticStartsData.isOpen[i]);
            }
            
            
            for (int i = 0; i < StaticStartsData.starCount.Length; i++)
            {
                string key = $"starCount1{i}";
                PlayerPrefs.SetInt(key, StaticStartsData.starCount[i]);
                Debug.Log(key + StaticStartsData.starCount[i]);
            }
            PlayerPrefs.SetInt("AllStar", Stats.Stars);
        }

    }

}



    
