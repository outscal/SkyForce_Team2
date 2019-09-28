using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  SkyForce.Bullet
{
    public class BulletView : MonoBehaviour
    {
        void Start()
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up*1000);
        }
    }
}
