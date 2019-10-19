using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Enemy
{
    [CreateAssetMenu(menuName = "ScriptableObjects/EnemySpawner")]
    public class EnemySpawnerScriptableObject : ScriptableObject
    {
        public float SpawnInterval;
        public int NoOfSpawns;
        public EnemyTypeEnum EnemyType;

    }
}
