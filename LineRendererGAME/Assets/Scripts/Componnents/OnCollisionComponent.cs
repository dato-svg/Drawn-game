using UnityEngine;
using UnityEngine.Events;

namespace Componnents
{
    public class OnCollisionComponent : MonoBehaviour
    {
        [SerializeField] private string target;
        [Space(20)]
        [SerializeField] private UnityEvent OnEnter;
        [SerializeField] private UnityEvent OnExit;

        [SerializeField] private bool destroyAnotherObject = true;
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag(target))
            {
                OnEnter?.Invoke();
                if (destroyAnotherObject)
                {
                    Destroy(other.gameObject);
                }
            }
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            if (other.gameObject.CompareTag(target))
            {
                OnExit?.Invoke();
            }
        }
    }
}
