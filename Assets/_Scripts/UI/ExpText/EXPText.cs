using System;
using UnityEngine;
using TMPro;

namespace Overloading.UI.ExpText
{
    public class EXPText : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI expText = null;
        public void SetValue(float amount)
        {
            expText.text = String.Format("XP: {0:0}", amount);
        }
    }
}

