using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Bullet;

namespace SkyForce.Enemy
{
    public class EnemyController
    {
        protected Transform playerObj;
        private bool isLoaded;
        public EnemyController(EnemyModel model,EnemyView prefab,Vector2 position)
        {
            enemyModel = model;
            
            enemyView = GameObject.Instantiate<EnemyView>(prefab,new Vector3(position.x, position.y, 0),Quaternion.identity);
            enemyView.Init(this);
            // Debug.Log(" type -" + model.EnemyType);
            isLoaded = true;
        }

        public void CheckAndFire()
        {
            if(isLoaded == true)
            {
                BulletService.Instance.GetBullet(enemyView.GetPosition(), Vector3.down);
                isLoaded = false;
                Reload();
            }
        }

        public async void Reload()
        {
            //await new WaitForSeconds(enemyModel.ReloadTime);
            await new WaitForSeconds(1);
            isLoaded = true;
        }

        public EnemyModel enemyModel { get; }
        public EnemyView enemyView { get; }
    }
}
