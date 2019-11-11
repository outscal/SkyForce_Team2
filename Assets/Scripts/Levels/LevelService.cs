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
        private LevelController controller;
        private int currentLevel;
        private int lastScore;

        public void CreateLevel(int lvlID)
        {
            if(controller != null)
            {
                controller.DestroyLevel();
            }
            currentLevel = lvlID;
            controller = new LevelController(levelPrefab[currentLevel]);
        }

        public int GetCurrentLevel()
        {
            return currentLevel;
        }

        public int GetLatestScore()
        {
            return lastScore;
        }

        public void SetLatestScore(int score)
        {
            lastScore = score;
        }
    }
}
