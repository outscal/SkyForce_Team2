using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.FighterJet
{
    [CreateAssetMenu(menuName="ScriptableObjects/PlayerJetScriptableObject")]
    public class PlayerJetScriptableObject : ScriptableObject
    {
        public FighterJetView JetPrefab;
        public float FiringDelay;
    }
}
