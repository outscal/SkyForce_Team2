using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  SkyForce.Bullet
{
    public class BulletView : MonoBehaviour
    {
        Rigidbody2D rigidBody;
        void Awake()
        {
            rigidBody = GetComponent<Rigidbody2D>();
        }

        public void ResetPositionTo(Vector3 newPosition)
        {
            gameObject.transform.position = newPosition;
        }

        public void SetViewStateEnabled(bool viewStateEnabled)
        {
            gameObject.SetActive(viewStateEnabled);
            if (viewStateEnabled)
            {
                rigidBody.AddForce(transform.up*1000);
            }
        }
    }
}
