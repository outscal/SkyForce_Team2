using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Player
{
    public class PlayerView : MonoBehaviour, IDamageable
    {
        private PlayerController controller;
        public void SetPositionTo(Vector3 newPosition)
        {
            transform.position = newPosition;
        }

        public Vector3 GetPosition()
        {
            return transform.position;
        }

        public void SetController(PlayerController _controller)
        {
            controller = _controller;
        }

        private void Update() 
        {
            if (controller == null)
            {
                return;
            }

            controller.CheckAndFire();
        }

        public bool TakeDamage(float destruction)
        {
            if(controller != null)
            {
                controller.TakeDamage(destruction);
            }
            return false;
        }

        public void DestroyView()
        {
            Destroy(gameObject);
        }
    }
}
