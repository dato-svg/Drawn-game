using UnityEngine;
using UnityEngine.Events;

namespace Componnents
{
    public class OnTriggerComponent : MonoBehaviour
    {
        [SerializeField] private string target;
        [Space(20)]
        [SerializeField] private UnityEvent OnEnter;
        [SerializeField] private UnityEvent OnExit;
       
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag(target))
            {
                OnEnter?.Invoke();
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.CompareTag(target))
            {
                OnExit?.Invoke();
            }
        }
    }
}
