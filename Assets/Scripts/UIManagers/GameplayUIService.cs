using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Generics;
using UnityEngine.UI;
using SkyForce.Player;

namespace SkyForce.UIManagers
{
    public class GameplayUIService : GenericMonoSingleton<GameplayUIService>
    {
        [SerializeField]
        private Slider HealthBar;

        public void UpdateUIHealthBar()
        {
            HealthBar.value = PlayerService.Instance.GetPlayerHealth();
        }
    }
}
