using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform EnemyType;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("NewEnemy", 1.0f, 5.0f);
    }

    void NewEnemy()
    {
        Instantiate(EnemyType, gameObject.transform.position, Quaternion.identity);
    }
}
