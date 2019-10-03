using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Bullet
{
    public class BulletService : GenericMonoSingleton<BulletService>
    {
        [SerializeField]
        private BulletScriptableObject jetBulletScriptableObject;
        private BulletPool playerBulletPool;

        private void Start() {
            playerBulletPool = new BulletPool();
        }

        public BulletController GetBullet(Vector3 position)
        {
            return playerBulletPool.GetBulletFromPool(jetBulletScriptableObject, position);
        }

    }
}
