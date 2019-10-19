using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Level
{
    public class LevelController
    {
        public LevelController(LevelView levelPrefab)
        {
            GameObject.Instantiate(levelPrefab);
        }
    }
}
