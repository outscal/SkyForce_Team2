using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Generics;
using SkyForce.Game.GameStates;

namespace SkyForce.Game
{
    public class GameService : GenericMonoSingleton<GameService>
    {
        [SerializeField]
        private GameplayState gameplayState;
        [SerializeField]
        private GameOverState gameOverState;
        private GameController gameController;
        void Start()
        {
            if(gameplayState != null)
            {
                gameController = new GameController(gameplayState);
            }
        }

        public void GameOver()
        {
            gameController.ChangeGameState(gameOverState);
        }
    }
}
