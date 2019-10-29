using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemyModel
    {
        public EnemyModel(EnemyScriptableObject enemyScriptablableObject)
        {
            EnemyType = enemyScriptablableObject.EnemyType;
            Speed = enemyScriptablableObject.Speed;
            Health = enemyScriptablableObject.Health;
            ReloadTime = enemyScriptablableObject.ReloadTime;
        }

        public float Speed { get; }
        public float Health { get; set;}
        public EnemyTypeEnum EnemyType { get; }
        public int Spawnspot { get; }
        public int PlayerId { get; }
        public float ReloadTime{ get;}
    }
}
