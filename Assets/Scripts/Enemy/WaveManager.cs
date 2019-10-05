using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public Transform playerObj;
    public EnemyWaveScriptableObject[] EnemyWave;
    // Start is called before the first frame update
    void Start()
    {
        EnemyWaveScriptableObject wave = EnemyWave[0];

        // Debug.Log((int)wave.EnemyType);
        SpawnWave(wave.EnemyWaveSize, (int)wave.EnemyWaveSize);
    }

    // Update is called once per frame
    void Update()
    {
        // GetJetPos();
        
    }

    private void SpawnWave(int size,int type)
    {
        for( int i = 0;i < size;i++ )
        {
            EnemyService.Instance.SpwanEnemy(type);
            Debug.Log("Enemy no "+i);
        }
    } 

    public Vector2 GetJetPos()
    {
        Vector2 pos;
        pos.x = playerObj.position.x;
        pos.y = playerObj.position.y;
        Debug.Log(pos);
        return pos;
    } 
}
