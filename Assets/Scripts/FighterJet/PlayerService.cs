using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Generics;

namespace SkyForce.Player
{
    [RequireComponent(typeof(PlayerInputHandler))]
    public class PlayerService : GenericMonoSingleton<PlayerService>
    {
        [SerializeField]
        private PlayerScriptableObject fighterJetData;
        private PlayerController fighterJet;

        void Start()
        {
            fighterJet = new PlayerController(fighterJetData);
        }

        public void SetFighterJetTo(Vector3 position)
        {
            fighterJet.SetPositionTo(position);
        }

        public Vector3 GetFighterJetPosition()
        {
            return fighterJet.GetPosition();
        }
    }
}
