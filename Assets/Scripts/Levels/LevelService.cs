using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Generics;

namespace SkyForce.Level
{
    public class LevelService : GenericMonoSingleton<LevelService>
    {
        [SerializeField]
        private LevelView[] levelPrefab;
        void Start()
        {
            new LevelController(levelPrefab[0]);
        }
    }
}
