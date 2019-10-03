using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Bullet;

namespace SkyForce.FighterJet
{
    public class FighterJetController
    {
        private FighterJetModel model;
        private FighterJetView view;
        private bool isLoaded;
        public FighterJetController(PlayerJetScriptableObject fighterJetProperties)
        {
            model = new FighterJetModel(fighterJetProperties);
            view = GameObject.Instantiate<FighterJetView>(model.JetPrefab, new Vector2(0,0), Quaternion.identity);
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
