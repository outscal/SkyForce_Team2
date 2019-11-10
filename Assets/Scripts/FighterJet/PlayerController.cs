﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Bullet;
using SkyForce.Game;
using SkyForce.UIManagers;
using SkyForce.Explosions;
using SkyForce.Audio;

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
            view.transform.parent = GameService.Instance.GetGameplayScene().transform;
            view.SetController(this);
            isLoaded = true;
            // GameplayUIService.Instance.UpdateUIHealthBar();
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
                BulletService.Instance.GetBullet(view.GetPosition(), Vector3.up, GameLayer.Player);
                isLoaded = false;
                Reload();
            }
        }

        public async void Reload()
        {
            await new WaitForSeconds(model.ReloadTime);
            isLoaded = true;
        }

        public bool TakeDamage(float destruction)
        {
            model.Health -= destruction;
            if (model.Health <= 0)
            {
                model.Health = 0;//avoiding negative values
                DestroyPlayer();
                GameService.Instance.GameOver();
            }
            else
            {
                GameplayUIService.Instance.UpdateUIHealthBar();
            }
            return true;
        }

        private void DestroyPlayer()
        {
            ExplosionService.Instance.CreateExplosion(view.GetPosition());
            AudioService.Instance.PlaySound(SoundTag.ExplosionEffect);
            model = null;
            view.DestroyView();
            view = null;
        }

        public float GetHealth()
        {
            return model.Health;
        }

        public void AddKill()
        {
            model.Kills = model.Kills + 1;
            GameplayUIService.Instance.UpdateUIScore();
        }

        public int GetKill()
        {
            return model.Kills;
        }
    }
}
