using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  SkyForce.Bullet
{
    public class BulletView : MonoBehaviour
    {
        Rigidbody2D rigidBody;
        private Vector3 direction;
        void Awake()
        {
            rigidBody = GetComponent<Rigidbody2D>();
        }

        public void ResetPositionTo(Vector3 newPosition)
        {
            gameObject.transform.position = newPosition;
        }

        public void ResetDirectionTo(Vector3 newDirection)
        {
            direction = newDirection;
        }

        public void SetViewStateEnabled(bool viewStateEnabled)
        {
            gameObject.SetActive(viewStateEnabled);
            if (viewStateEnabled)
            {
                rigidBody.AddForce(direction*1000);
            }
        }
    }
}
