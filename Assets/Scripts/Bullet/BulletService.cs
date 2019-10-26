using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Generics;
using SkyForce.Game;

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

        public BulletController GetBullet(Vector3 position, Vector3 direction, GameLayer source)
        {
            return playerBulletPool.GetBulletFromPool(jetBulletScriptableObject, position, direction, source);
        }

    }
}
