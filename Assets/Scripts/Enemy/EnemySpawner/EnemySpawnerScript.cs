using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemySpawnerScript : MonoBehaviour
    {
        [SerializeField]
        private EnemySpawnerScriptableObject spawnerProperties;

        void OnTriggerEnter2D(Collider2D coll)
        {
            if(coll.gameObject.layer == 9)
            {
                Debug.Log("Collission detected....spawning enemy");

                EnemyService.Instance.SpawnWave(spawnerProperties.EnemyWaveProperties);
            }
        }
    }
}
