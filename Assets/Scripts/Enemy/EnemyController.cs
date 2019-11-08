using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Bullet;
using SkyForce.Game;
using SkyForce.Player;
using SkyForce.Explosions;

namespace SkyForce.Enemy
{
    public class EnemyController
    {
        private EnemyModel enemyModel;
        private EnemyView enemyView;
        protected Transform playerObj;
        private bool isLoaded;
        public EnemyController(EnemyModel model,EnemyView prefab,Vector2 position)
        {
            enemyModel = model;
            
            enemyView = GameObject.Instantiate<EnemyView>(prefab,new Vector3(position.x, position.y, 0),Quaternion.identity);
            enemyView.transform.parent = GameService.Instance.GetGameplayScene().transform;
            enemyView.Init(this);
            isLoaded = true;
        }

        public void CheckAndFire()
        {
            if(isLoaded == true)
            {
                BulletService.Instance.GetBullet(enemyView.GetPosition(), Vector3.down, GameLayer.Enemy);
                isLoaded = false;
                Reload();
            }
        }

        public async void Reload()
        {
            await new WaitForSeconds(enemyModel.ReloadTime);
            isLoaded = true;
        }

        private void DestroyEnemy()
        {
            ExplosionService.Instance.CreateExplosion(enemyView.GetPosition());
            enemyModel = null;
            enemyView.DestroyEnemyView();
            enemyView = null;
        }

        public bool TakeDamage(float destruction)
        {
            enemyModel.Health -= destruction;
            if (enemyModel.Health <= 0)
            {
                enemyModel.Health = 0;//avoiding negative values
                PlayerService.Instance.AddKill();
                DestroyEnemy();
            }
            // GameplayUIService.Instance.UpdateUIHealthBar();
            return true;
        }
    }
}
