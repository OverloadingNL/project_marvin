using System;
using Overloading.Saving;
using Overloading.UI.ExpText;
using UnityEngine;

namespace Overloading.Stats
{
    public class Experience : MonoBehaviour, ISaveable
    {
        [SerializeField] float experiencePoints = 0;

        public event Action onExperienceGained;

        public void GainExperience(float experience)
        {
            experiencePoints += experience;
            onExperienceGained();
            EXPTextSpawner expTextSpawner = FindObjectOfType<EXPTextSpawner>().GetComponent<EXPTextSpawner>();
            expTextSpawner.Spawn(experience);
        }

        public float GetPoints()
        {
            return experiencePoints;
        }

        #region Saving
        public object CaptureState()
        {
            return experiencePoints;
        }

        public void RestoreState(object state)
        {
            experiencePoints = (float)state;
        }
        #endregion
    }
}
