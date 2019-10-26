using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemySpawnerScript : MonoBehaviour
    {
        [SerializeField]
        private EnemySpawnerScriptableObject spawnerProperties;

        void OnCollisionEnter2D(Collision2D coll)
        {
            if(coll.gameObject.layer == 9)
            {
                Debug.Log("Collission detected....spawning enemy");

                Vector3 enemySpawnPos = Camera.main.gameObject.transform.position.AddY(5).SetZ(0);

                EnemyService.Instance.SpwanEnemy(spawnerProperties.EnemyType, enemySpawnPos);
            }
        }
    }
}
