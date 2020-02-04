using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public float AliveTime;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, AliveTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
