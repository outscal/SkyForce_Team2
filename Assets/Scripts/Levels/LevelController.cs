using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Game;

namespace SkyForce.Level
{
    public class LevelController
    {
        private LevelView levelView;
        public LevelController(LevelView levelPrefab)
        {
            levelView = GameObject.Instantiate(levelPrefab);
            levelView.transform.parent = GameService.Instance.GetGameplayScene().transform;
        }

        public void DestroyLevel()
        {
            GameObject.Destroy(levelView);
        }
    }
}
