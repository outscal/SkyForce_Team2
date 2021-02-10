using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  SkyForce.Enemy
{
    [CreateAssetMenu(menuName="ScriptableObjects/EnemyWaveScriptableObject")]
    public class EnemyWaveScriptableObject : ScriptableObject
    {
        public EnemyTypeEnum EnemyType;
        public int EnemyWaveSize; 
    }
}
