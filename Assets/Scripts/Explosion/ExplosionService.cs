using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Generics;
using SkyForce.Game;

namespace SkyForce.Explosions
{
    public class ExplosionService : GenericMonoSingleton<ExplosionService>
    {
        [SerializeField]
        private ExplosionView[] explosionPrefabs;

        public void CreateExplosion(Vector3 explodeAt)
        {
            int explosionIndex = Random.Range(0, explosionPrefabs.Length);
            ExplosionView explosion = GameObject.Instantiate(explosionPrefabs[explosionIndex], explodeAt, Quaternion.identity); 
            explosion.transform.parent = GameService.Instance.GetGameplayScene().transform;
        }
    }
}
