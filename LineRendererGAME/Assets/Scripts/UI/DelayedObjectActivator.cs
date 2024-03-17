using System.Collections;
using UnityEngine;

namespace UI
{
    public class DelayedObjectActivator : MonoBehaviour
    {
        [SerializeField] private GameObject objectActivate;
        [SerializeField] private float menuOpenDelay;
    
        public void StartCoroutineOpenObject()
        {
            StartCoroutine(OpenObject());
        }

        private IEnumerator OpenObject()
        {
            float elapsedTime = 0;
            while (elapsedTime < menuOpenDelay)
            {
                elapsedTime += Time.deltaTime;
                yield return null;
            }
            yield return null;
            objectActivate.SetActive(true);
      
        }
    
    }
}
