using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Generics;

namespace SkyForce.Enemy
{
    public class EnemyService : GenericMonoSingleton<EnemyService>
    {
        private EnemyController enemyController;

        private EnemyController SpwanEnemy(EnemyScriptableObject enemyProperties, Vector3 position)
        {
            EnemyModel EnemyModel = new EnemyModel(enemyProperties);
            EnemyView EnemyView = enemyProperties.EnemyView;   
            enemyController = new EnemyController(EnemyModel, EnemyView, position);
            
            return enemyController;
        }

        public async void SpawnWave(EnemyWaveScriptableObject waveProperties)
        {
            for (int i = 0; i < waveProperties.EnemyWaveSize; i++)
            {
                Vector3 enemySpawnPos = Camera.main.gameObject.transform.position.AddY(5).SetZ(0).AddX(waveProperties.offsetsFromCenter[i]);
                SpwanEnemy(waveProperties.EnemyProperties, enemySpawnPos);
                if(i+1 < waveProperties.EnemyWaveSize)
                {
                    await new WaitForSeconds(waveProperties.delayFromFirstEnemy[i+1]);
                }
            }
        } 
    }
}
