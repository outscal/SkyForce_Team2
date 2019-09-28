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
        public bool IsLoaded{get; set; }
        public FighterJetController(PlayerJetScriptableObject fighterJetProperties)
        {
            model = new FighterJetModel(fighterJetProperties);
            view = GameObject.Instantiate<FighterJetView>(model.JetPrefab, new Vector2(0,0), Quaternion.identity);
            view.SetController(this);
            IsLoaded = true;
        }

        public void SetPositionTo(Vector3 newPosition)
        {
            view.SetPositionTo(newPosition);
        }

        public void CheckAndFire()
        {
            if(IsLoaded == true)
            {
                BulletService.Instance.GetBullet(view.GetPosition());
                IsLoaded = false;
                view.Reload();
            }
        }
    }
}
