using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SkyForce.Game;
using SkyForce.Level;

namespace SkyForce.UIScreens
{
    public class GameOverScreen : MonoBehaviour
    {
        [SerializeField]
        private Button playAgainBtn;

        [SerializeField]
        private Button backBtn;
        [SerializeField]
        private Text score;

        void Start()
        {
            playAgainBtn.onClick.AddListener(() => PlayAgain());
            backBtn.onClick.AddListener(() => Exit());
        }

        private void Awake() 
        {
            score.text = LevelService.Instance.GetLatestScore().ToString();
        }

        private void PlayAgain()
        {
            GameService.Instance.StartGamePlay(LevelService.Instance.GetCurrentLevel());
        }

        private void Exit()
        {
            GameService.Instance.EnterLevelSelectionScene();
        }
    }
}
