using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Game;

namespace  SkyForce.Bullet
{
    public class BulletController
    {
        private BulletView view;
        private BulletPool parentPool;
        private GameLayer bulletSource;
        public BulletController(BulletScriptableObject _bulletProperties, BulletPool _parentPool)
        {
            view = GameObject.Instantiate<BulletView>(_bulletProperties.bulletPrefab, Vector3.zero, Quaternion.identity);
            parentPool = _parentPool;
        }

        public void Initialise(Vector3 position, Vector3 direction, GameLayer _source)
        {
            bulletSource = _source;
            view.ResetPositionTo(position);
            view.ResetDirectionTo(direction);
            view.SetViewStateEnabled(true);
            view.SetController(this);
            InitiateBurnoutTimer();
        }

        private async void InitiateBurnoutTimer()
        {
            await new WaitForSeconds(4);
            view.SetViewStateEnabled(false);
            parentPool.ReturnItem(this);

        }

        public void HandleCollissionWith(Collision2D coll)
        {
            if(coll.gameObject.layer == (int)GameLayer.Player && bulletSource != GameLayer.Player)
            {
                Debug.Log("bullet Collission detected....with player");
                IDamageable playerDamageComponent = coll.gameObject.GetComponent<IDamageable>();
                playerDamageComponent.TakeDamage(10);
            }
            else if(coll.gameObject.layer == (int)GameLayer.Enemy && bulletSource != GameLayer.Enemy)
            {
                Debug.Log("bullet Collission detected....with Enemy");
                IDamageable playerDamageComponent = coll.gameObject.GetComponent<IDamageable>();
                playerDamageComponent.TakeDamage(10);
            }
        }
    }
}
