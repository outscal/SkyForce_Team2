using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Bullet
{
    public class BulletService : GenericMonoSingleton<BulletService>
    {
        [SerializeField]
        private BulletScriptableObject jetBulletScriptableObject;
        public BulletController GetBullet(Vector3 position)
        {
            return new BulletController(jetBulletScriptableObject, position);
        }

    }
}
