using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Bullet
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Bullet")]
    public class BulletScriptableObject : ScriptableObject
    {
        public BulletView bulletPrefab;
    }
}
