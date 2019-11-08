using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  SkyForce.Bullet
{
    public class BulletView : MonoBehaviour
    {
        private Vector3 direction;
        private BulletController controller;
        private bool isViewEnabled;
        void Awake()
        {
            isViewEnabled = false;
        }

        private void Update() 
        {
            if (isViewEnabled)
            {
                gameObject.transform.position += direction/9; 
            }
        }

        public void ResetPositionTo(Vector3 newPosition)
        {
            gameObject.transform.position = newPosition;
        }

        public void SetController(BulletController _controller)
        {
            controller = _controller;
        }

        public void ResetDirectionTo(Vector3 newDirection)
        {
            direction = newDirection;
        }

        public void SetViewStateEnabled(bool viewStateEnabled)
        {
            isViewEnabled = viewStateEnabled;
            gameObject.SetActive(viewStateEnabled);
        }

        void OnTriggerEnter2D(Collider2D coll)
        {
            if (controller != null)
            {
                controller.HandleCollissionWith(coll);
            }
        }
    }
}
