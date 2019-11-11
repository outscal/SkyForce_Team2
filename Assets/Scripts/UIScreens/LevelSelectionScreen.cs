using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SkyForce.Game;

namespace SkyForce.UIScreens
{
    public class LevelSelectionScreen : MonoBehaviour
    {
        [SerializeField]
        private Button[] levelButtons;
        void Start()
        {
            for (int i = 0; i < levelButtons.Length; i++)
            {
                levelButtons[i].onClick.AddListener(() => OnLvlbtnClick(i));
            }
        }


        public void OnLvlbtnClick(int btnID)
        {
            GameService.Instance.StartGamePlay(0);
        }
    }
}
