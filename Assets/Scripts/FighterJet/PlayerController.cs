using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Bullet;
using SkyForce.Game;
using SkyForce.UIManagers;
using SkyForce.Explosions;
using SkyForce.Audio;
using SkyForce.Level;

namespace SkyForce.Player
{
    public class PlayerController
    {
        private PlayerModel model;
        private PlayerView view;
        private bool isLoaded;
        private PlayerScriptableObject fighterJetProperties;
        public PlayerController(PlayerScriptableObject _fighterJetProperties)
        {
            fighterJetProperties = _fighterJetProperties;
        }

        public void InitPlayer()
        {
            if (model == null)
            {
                model = new PlayerModel(fighterJetProperties);
            }
            if (view == null)
            {
                view = GameObject.Instantiate<PlayerView>(model.JetPrefab, new Vector2(0,0), Quaternion.identity);
            }
            view.transform.parent = GameService.Instance.GetGameplayScene().transform;
            view.SetController(this);
            isLoaded = true;
            GameplayUIService.Instance.UpdateUIHealthBar();
            GameplayUIService.Instance.UpdateUIScore();
        }

        public void SetPositionTo(Vector3 newPosition)
        {
            if(view != null)
            {
                view.SetPositionTo(newPosition);
            }
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
            if(model==null)
            {
                return false;
            }
            model.Health -= destruction;
            if (model.Health <= 0)
            {
                model.Health = 0;//avoiding negative values
                GameplayUIService.Instance.UpdateUIHealthBar();
                DestroyPlayer();
                GameService.Instance.GameOver();
            }
            else
            {
                AudioService.Instance.PlaySound(SoundTag.PlayerHit);
                GameplayUIService.Instance.UpdateUIHealthBar();
            }
            return true;
        }

        private void DestroyPlayer()
        {
            LevelService.Instance.SetLatestScore(model.Kills*10);
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
            if (model == null)
            {
                return;
            }
            model.Kills = model.Kills + 1;
            GameplayUIService.Instance.UpdateUIScore();
        }

        public int GetKill()
        {
            return model.Kills;
        }
    }
}
