using UnityEngine;
using UnityEngine.SceneManagement;


namespace Componnents
{
    public class SceneControllerComponent : MonoBehaviour
    {
        [Tooltip("Need For Active Certain Scene")]
        [SerializeField] private string sceneName;

        public void ReloadScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void NextScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void ActiveCertainScene()
        {
            SceneManager.LoadScene(sceneName);
        }
        
    }
}
