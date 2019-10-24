using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Game.GameStates;

namespace SkyForce.Game
{
    public class GameController
    {
        private GameState currentGameState;
        public GameController(GameState initialState)
        {
            ChangeGameState(initialState);
        }

        public void ChangeGameState(GameState newState)
        {
            if (currentGameState != null)
            {
                currentGameState.OnExitState();
            }
            currentGameState = newState;
            currentGameState.OnEnterState();
        }
    }
}
