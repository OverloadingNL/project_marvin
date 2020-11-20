using UnityEngine;

namespace Overloading.Core
{
    public class DestroyTarget : MonoBehaviour
    {
        [SerializeField] GameObject targetToDestroy = null;

        public void DestroyTargetObject()
        {
            Destroy(targetToDestroy);
        }
    }
}

