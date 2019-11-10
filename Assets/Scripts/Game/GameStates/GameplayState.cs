using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Audio;

namespace SkyForce.Game.GameStates
{
    public class GameplayState : GameState
    {
        public override void OnEnterState()
        {
            base.OnEnterState();
            AudioService.Instance.PlaySound(SoundTag.GameplayBGM);
        }

        public override void OnExitState()
        {
            base.OnExitState();
            AudioService.Instance.StopSound(SoundTag.GameplayBGM);
        }
    }
}
