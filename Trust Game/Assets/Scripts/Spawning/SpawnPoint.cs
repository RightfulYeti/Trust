using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform EnemyType;
    public float SpawnRate; // In Seconds
    public int TotalEnemyAmount; // Max amount of enemies spawned by this spawn point
    private int EnemyCounter;
    public bool Movable;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("NewEnemy", 1.0f, SpawnRate);
        if (!Movable)
        {
            EnemyType.GetComponent<EnemyAI>().Movable = Movable;
        }

    }

    void NewEnemy()
    {
        if (EnemyCounter < TotalEnemyAmount)
        {
            Instantiate(EnemyType, gameObject.transform.position, Quaternion.identity);
            EnemyCounter++;
        }
        
    }
}
