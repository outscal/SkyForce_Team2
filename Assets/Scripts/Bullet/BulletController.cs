using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  SkyForce.Bullet
{
    public class BulletController
    {
        private BulletView view;
        private BulletPool parentPool;
        public BulletController(BulletScriptableObject _bulletProperties, BulletPool _parentPool)
        {
            view = GameObject.Instantiate<BulletView>(_bulletProperties.bulletPrefab, Vector3.zero, Quaternion.identity);
            parentPool = _parentPool;
        }

        public void Initialise(Vector3 position)
        {
            view.ResetPositionTo(position);
            view.SetViewStateEnabled(true);
            InitiateBurnoutTimer();
        }

        private async void InitiateBurnoutTimer()
        {
            await new WaitForSeconds(4);
            view.SetViewStateEnabled(false);
            parentPool.ReturnItem(this);

        }
    }
}
