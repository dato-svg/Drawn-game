using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI levelCountText;
        [SerializeField] private TextMeshProUGUI lineCountText;
        public int lineCount = 2;
        
        
        private void Start()
        {
            ShowStats();
        }

        public void ChangeCount(int count)
        {
            lineCount += count;
            ShowStats();
        }
        


        public void ShowStats()
        {
            var lvlIndex = SceneManager.GetActiveScene().buildIndex - 2;
            levelCountText.text = lvlIndex.ToString();
            lineCountText.text = lineCount.ToString();
        }
    }
}
