using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

namespace Componnents
{
    public class SpawnObject : MonoBehaviour
    {
        [SerializeField] private GameObject prefabs;
        [SerializeField] private float delay;
        [SerializeField] private Transform spawnPosition;
        [SerializeField] private Transform parentCanvas;
        [SerializeField] private int objectquantity;
        
        public void SpawnWithDelay()
        {
            Invoke(nameof(StartCoroutineSpawn),delay);
            GetComponent<Button>().enabled = false;
            GetComponent<Image>().enabled = false;
        }


        private void StartCoroutineSpawn()
        {
            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            for (int i = 0; i < objectquantity; i++)
            {
                GameObject obj = Instantiate(prefabs, spawnPosition.position, quaternion.identity);
                obj.transform.SetParent(parentCanvas);
                yield return new WaitForSeconds(0.1f);
            }

            yield return null;
            gameObject.SetActive(false);
        }

    }
}
