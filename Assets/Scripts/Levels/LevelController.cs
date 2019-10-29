using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Game;

namespace SkyForce.Level
{
    public class LevelController
    {
        public LevelController(LevelView levelPrefab)
        {
            GameObject.Instantiate(levelPrefab).transform.parent = GameService.Instance.GetGameplayScene().transform;
        }
    }
}
