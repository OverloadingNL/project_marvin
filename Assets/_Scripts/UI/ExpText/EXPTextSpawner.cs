using UnityEngine;

namespace Overloading.UI.ExpText
{
    public class EXPTextSpawner : MonoBehaviour
    {
        [SerializeField] EXPText expTextPrefab = null;

        public void Spawn(float expAmount)
        {
            EXPText instance = Instantiate<EXPText>(expTextPrefab, transform);
            instance.SetValue(expAmount);
        }
    }
}