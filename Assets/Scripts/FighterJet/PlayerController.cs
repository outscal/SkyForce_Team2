using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Bullet;

namespace SkyForce.Player
{
    public class PlayerController
    {
        private PlayerModel model;
        private PlayerView view;
        private bool isLoaded;
        public PlayerController(PlayerScriptableObject fighterJetProperties)
        {
            model = new PlayerModel(fighterJetProperties);
            view = GameObject.Instantiate<PlayerView>(model.JetPrefab, new Vector2(0,0), Quaternion.identity);
            view.SetController(this);
            isLoaded = true;
        }

        public void SetPositionTo(Vector3 newPosition)
        {
            view.SetPositionTo(newPosition);
        }

        public Vector3 GetPosition()
        {
            return view.GetPosition();
        }

        public void CheckAndFire()
        {
            if(isLoaded == true)
            {
                BulletService.Instance.GetBullet(view.GetPosition());
                isLoaded = false;
                Reload();
            }
        }

        public async void Reload()
        {
            await new WaitForSeconds(model.ReloadTime);
            isLoaded = true;
        }
    }
}
