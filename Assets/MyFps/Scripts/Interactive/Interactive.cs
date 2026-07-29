using UnityEngine;

namespace MyFps
{
    public abstract class Interactive : MonoBehaviour
    {
        protected Collider castCollider;

        protected virtual void Awake()
        {
            castCollider = GetComponent<Collider>();
        }

        protected abstract void DoAction();
    }
}
