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
        private enum SpawnSide
        {
            Up = 0,
            Left = 1,
            Right = 2,
        }
        void Start()
        {
            EnemyWaveScriptableObject wave = EnemyWave[0];

            startWait = 3.0f;
            spawnWait = 1.0f;
            waveWait = 15.0f;
            // Debug.Log((int)wave.EnemyType);
            SpawnSide side; 
            int index = (int)Random.Range(1.0f, 2.0f);
            Debug.Log(index);
            side = (SpawnSide)index;
            Debug.Log(side);
            waveRoutine = StartCoroutine (SpawnWave(wave.EnemyWaveSize, wave.EnemyType,side));
            // playerObj = gameObject.transform.GetComponent<PlayerView>();
        }

        // Update is called once per frame
        void Update()
        {
            // GetJetPos();
            
        }

        IEnumerator SpawnWave(int size,EnemyTypeEnum type,SpawnSide side)
        {
            yield return new WaitForSeconds(startWait);
            while (true)
            {
                Vector2 position = GetCameraPos();

                for (int i = 1; i <= size; i++)
                {
                    EnemyService.Instance.SpwanEnemy(type, position);

                    
                        position.y += 2.0f;
                    // Debug.Log("Enemy no "+i);
                    yield return new WaitForSeconds(spawnWait);
                }
                yield return new WaitForSeconds(waveWait);
            }
            
        } 

        public Vector2 GetCameraPos()
        {
            Vector2 pos;
            pos.x = cameraPos.position.x;
            pos.y = cameraPos.position.y + 5.0f;
            return pos;
        } 
    }
}
