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

                //EnemyService.Instance.SpwanEnemy()
            }
        }
    }
}
