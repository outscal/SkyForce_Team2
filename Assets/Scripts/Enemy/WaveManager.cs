﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Generics;

public class WaveManager : GenericMonoSingleton<WaveManager>
{
    public Transform cameraPos;
    public bool stopWave = false;
    public EnemyWaveScriptableObject[] EnemyWave;
    private float startWait;
    private float waveWait;
    private Coroutine resumeWave;
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

        // Debug.Log((int)wave.EnemyType);
        waveWait = 15.0f;
        startWait = 3.0f;
        SpawnSide side; 
        float _index = Random.Range(0, 2.0f);
        int index = (int)_index;
        Debug.Log(index);
        side = (SpawnSide)index;
        Debug.Log(side);
        resumeWave = StartCoroutine (SpawnWave(wave.EnemyWaveSize, (int)wave.EnemyType,side));
        // playerObj = gameObject.transform.GetComponent<PlayerView>();
    }

    // Update is called once per frame
    void Update()
    {
        // GetJetPos();
        
    }

    IEnumerator SpawnWave(int size,int type,SpawnSide side)
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            Vector2 position = GetCameraPos();

            for (int i = 0; i < size; i++)
            {
                EnemyService.Instance.SpwanEnemy(type, position);

                
                    position.y += 2.0f;
                // Debug.Log("Enemy no "+i);
                yield return new WaitForSeconds(1.0f);
            }
            Debug.Log(waveWait);
            yield return new WaitForSeconds(waveWait);

            if(stopWave)
            {
                break;
            }
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
