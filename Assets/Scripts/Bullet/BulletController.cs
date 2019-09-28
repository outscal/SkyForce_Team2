using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  SkyForce.Bullet
{
    public class BulletController
    {
        private BulletView view;
        public BulletController(BulletScriptableObject bulletProperties, Vector3 position)
        {
            view = GameObject.Instantiate<BulletView>(bulletProperties.bulletPrefab, position, Quaternion.identity);
        }
    }
}
