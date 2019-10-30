using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Generics;

namespace SkyForce.Enemy
{
    public class WaveManager : GenericMonoSingleton<WaveManager>
    {
        public Transform cameraPos;
        public EnemyWaveScriptableObject[] EnemyWave;
        private Coroutine waveRoutine;
        private float startWait;
        private float waveWait;
        private float spawnWait;

        // Start is called before the first frame update
        
        void Start()
        {
            EnemyWaveScriptableObject wave = EnemyWave[0];

            startWait = 3.0f;
            spawnWait = 1.0f;
            waveWait = 15.0f;
        }
    }
}
