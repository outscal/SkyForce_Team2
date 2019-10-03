using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  SkyForce.Bullet
{
    public class BulletView : MonoBehaviour
    {
        void Start()
        {
            
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
                GetComponent<Rigidbody2D>().AddForce(transform.up*1000);
            }
        }
    }
}
