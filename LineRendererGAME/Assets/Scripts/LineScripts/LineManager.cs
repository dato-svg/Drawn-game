using UI;
using UnityEngine;

namespace LineScripts
{
    public class LineManager : MonoBehaviour
    {
        [SerializeField] private Line _prefabs;
        [SerializeField] private Camera _cam;
        [SerializeField] private UIManager uIManager;
        [SerializeField] private bool education = false;
        [SerializeField] private GameObject educationObject;
        public const float SPEED = 0.1f;
        public Vector3 offcet;
        public GameObject GameActivator;
    
        private Line _currentObject;
        private static readonly int Click = Animator.StringToHash("Click");


        private void Start()
        {
            Stats.FirstJoin = 1;
            PlayerPrefs.SetInt("FirstJoin",Stats.FirstJoin);
            uIManager = FindObjectOfType<UIManager>();
            educationObject = GameObject.Find("EducationImage");
            _cam = Camera.main;
        }


        private void Update()
        {
            Vector2 mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
            if (uIManager.lineCount > 0)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    
                    
                    _currentObject = Instantiate(_prefabs, mousePos, Quaternion.identity);
                    
                }

                if (Input.GetMouseButtonUp(0))
                {
                    uIManager.ChangeCount(-1);
                    if (education)
                    {
                        educationObject.GetComponent<RectTransform>().position =
                            GameActivator.GetComponent<RectTransform>().position + offcet;
                        educationObject.GetComponent<Animator>().enabled = false;

                    }
                }

                if (Input.GetMouseButton(0))
                {
                    _currentObject.SetPosition(mousePos);
                } 
            }
            
            
        }

       
    }
}
