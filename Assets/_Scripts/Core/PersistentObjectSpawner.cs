using UnityEngine;

namespace Overloading.Core
{

    public class PersistentObjectSpawner : MonoBehaviour
    {
        [SerializeField] GameObject persistantObjectPrefab;

        static bool hasSpawned = false;

        private void Awake()
        {
            if (hasSpawned)
            {
                return;
            }

            SpawnPersistantObject();

            hasSpawned = true;
        }

        private void SpawnPersistantObject()
        {
            GameObject persistantObject = Instantiate(persistantObjectPrefab);
            DontDestroyOnLoad(persistantObject);
        }
    }
}
