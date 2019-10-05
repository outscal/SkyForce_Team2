using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{

    private EnemyController enemyController;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * -Time.deltaTime;
    }
    public void Init(EnemyController c)
    {
        this.enemyController = c;
    }
}
