using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.FighterJet
{
    [RequireComponent(typeof(PlayerInputHandler))]
    public class FighterJetService : GenericMonoSingleton<FighterJetService>
    {
        [SerializeField]
        private PlayerJetScriptableObject fighterJetData;
        private FighterJetController fighterJet;

        void Start()
        {
            fighterJet = new FighterJetController(fighterJetData);
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
