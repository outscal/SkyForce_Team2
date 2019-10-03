using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.FighterJet
{
    public class FighterJetModel
    {
        private FighterJetView jetPrefab;
        public FighterJetView JetPrefab{get {return jetPrefab; }}
        private float reloadTime;
        public float ReloadTime{ get{ return reloadTime; }}
        public FighterJetModel(PlayerJetScriptableObject jetProperties)
        {
            jetPrefab = jetProperties.JetPrefab;
            reloadTime = jetProperties.ReloadTime;
        }
    }
}
