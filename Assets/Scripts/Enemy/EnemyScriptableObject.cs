using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Enemy
{
    [CreateAssetMenu(fileName = "EnemyScriptableObject", menuName = "ScriptableObjects/NewEnemyScriptableObject")]
    public class EnemyScriptableObject : ScriptableObject
    {
        public EnemyTypeEnum EnemyType;
        public EnemyView EnemyView;
        public float Health;
        public float Speed;
        public float ReloadTime;
    }
}
