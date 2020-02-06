using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float Length;
    private float StartPos;
    public GameObject Camera;
    public float ParallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position.x;
        Length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float Temp = Camera.transform.position.x * (1 - ParallaxEffect);
        float Distance = Camera.transform.position.x * ParallaxEffect;
        transform.position = new Vector3(StartPos + Distance, transform.position.y, transform.position.z);

        if (Temp > StartPos + Length)
        {
            StartPos += Length;
        }
        else if (Temp < StartPos - Length)
        {
            StartPos -= Length;
        }
    }
}
