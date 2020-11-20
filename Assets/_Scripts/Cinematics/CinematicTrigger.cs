using Overloading.Saving;
using UnityEngine;
using UnityEngine.Playables;

namespace Overloading.Cinematics
{
    public class CinematicTrigger : MonoBehaviour, ISaveable
    {
        bool alreadyTriggered = false;


        private void OnTriggerEnter(Collider other)
        {
            if (!alreadyTriggered && other.gameObject.tag == "Player")
            {
                GetComponent<PlayableDirector>().Play();
                alreadyTriggered = true;
            }
        }

        #region Saving
        public object CaptureState()
        {
            return alreadyTriggered;
        }

        public void RestoreState(object state)
        {
            alreadyTriggered = (bool)state;
        }
        #endregion
    }
}
