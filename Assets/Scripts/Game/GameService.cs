using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Generics;
using SkyForce.Game.GameStates;
using SkyForce.Level;

namespace SkyForce.Game
{
    public class GameService : GenericMonoSingleton<GameService>
    {
        [SerializeField]
        private GameplayState gameplayState;
        [SerializeField]
        private GameOverState gameOverState;
        [SerializeField]
        private LevelSelectionState levelSelectionState;
        [SerializeField]
        private GameWinState gameWinState;
        private GameController gameController;
        void Start()
        {
            if(gameplayState != null)
            {
                gameController = new GameController(levelSelectionState);
            }
        }

        public async void GameOver()
        {
            await new WaitForSeconds(3.0f);
            gameController.ChangeGameState(gameOverState);
        }

        public void EnterLevelSelectionScene()
        {
            gameController.ChangeGameState(levelSelectionState);
        }

        public GameplayState GetGameplayScene()
        {
            return gameplayState;
        }

        public void StartGamePlay(int lvlID)
        {
            gameController.ChangeGameState(gameplayState);
            LevelService.Instance.CreateLevel(lvlID);
        }
    }
}
