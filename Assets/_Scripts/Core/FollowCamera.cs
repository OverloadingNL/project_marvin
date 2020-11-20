using UnityEngine;

namespace Overloading.Core
{
    public class FollowCamera : MonoBehaviour
    {
        GameObject player;

        private void Start()
        {
            player = GameObject.FindWithTag("Player");
        }

        private void LateUpdate()
        {
            transform.position = player.transform.position;
        }

    }
}
