using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  SkyForce.Enemy
{
    [CreateAssetMenu(menuName="ScriptableObjects/EnemyWaveScriptableObject")]
    public class EnemyWaveScriptableObject : ScriptableObject
    {
        public EnemyScriptableObject EnemyProperties;
        public int EnemyWaveSize;
        public float[] offsetsFromCenter;
        public float[] delayFromFirstEnemy;
    }
}
