using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float Range;
    public float Damage;
    PlayerController PlayerControllerRef;
    GameObject BulletSpawnRef;

    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerRef = FindObjectOfType<PlayerController>();
        BulletSpawnRef = GameObject.Find("Bullet Spawn");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
