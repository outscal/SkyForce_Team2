using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.FighterJet
{
    public class FighterJetModel
    {
        private FighterJetView jetPrefab;
        public FighterJetView JetPrefab{get {return jetPrefab; }}
        public FighterJetModel(PlayerJetScriptableObject jetProperties)
        {
            jetPrefab = jetProperties.JetPrefab;
        }
    }
}
