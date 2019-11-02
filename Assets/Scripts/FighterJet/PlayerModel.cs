using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Player
{
    public class PlayerModel
    {
        private PlayerView jetPrefab;
        public PlayerView JetPrefab{get {return jetPrefab; }}
        private float reloadTime;
        public float ReloadTime{ get{ return reloadTime; }}
        private float health;
        public float Health{get{return health;} set{health = value;}}
        private int kills;
        public int Kills{get{ return kills;} set{ kills = value;}}

        public PlayerModel(PlayerScriptableObject jetProperties)
        {
            jetPrefab = jetProperties.JetPrefab;
            reloadTime = jetProperties.ReloadTime;
            health = 100;
            kills = 0;
        }
    }
}
