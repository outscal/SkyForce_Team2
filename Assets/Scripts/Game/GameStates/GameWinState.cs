using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Audio;

namespace SkyForce.Game.GameStates
{
    public class GameWinState : GameState
    {
        public override void OnEnterState()
        {
            base.OnEnterState();
            AudioService.Instance.PlaySound(SoundTag.MenuBGM);
        }

        public override void OnExitState()
        {
            base.OnExitState();
            AudioService.Instance.StopSound(SoundTag.MenuBGM);
        }
    }
}
