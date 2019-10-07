using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Player
{
    [CreateAssetMenu(menuName="ScriptableObjects/PlayerJetScriptableObject")]
    public class PlayerScriptableObject : ScriptableObject
    {
        public PlayerView JetPrefab;
        public float ReloadTime;
    }
}
