using System.Collections;
using UnityEngine;

namespace MyFps
{
    public abstract class SequenceTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                StartCoroutine(SequencePlay(other.gameObject));
                var col = GetComponent<Collider>();
                if (col != null)
                {
                    col.enabled = false;
                }
            }
        }

        protected abstract IEnumerator SequencePlay(GameObject player);
    }
}
