﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Generics;
using SkyForce.Game;

namespace SkyForce.Bullet
{
    public class BulletPool : GenericPool<BulletController>
    {
        private BulletScriptableObject bulletProperties;
        private Vector3 position;
        
        public BulletController GetBulletFromPool(BulletScriptableObject _bulletProperties, Vector3 _position, Vector3 _direction, GameLayer _source)
        {
            bulletProperties = _bulletProperties;
            position = _position;
            BulletController bullet = GetItem();
            bullet.Initialise(_position, _direction, _source);
            return bullet;
        }
        public override BulletController CreatePooledItem()
        {
            if (bulletProperties == null)
            {
                Debug.LogError("Should use GetBulletFromPool with bulletProperties as argument");
            }
            return new BulletController(bulletProperties, this);
        } 
    }
}
