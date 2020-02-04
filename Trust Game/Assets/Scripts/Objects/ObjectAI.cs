using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAI : MonoBehaviour
{
    private float Direction = 1.0f;
    private float Timer = 0.0f;
    private bool Changed = false;
    public bool Movable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Movable)
        {
            gameObject.transform.position += new Vector3(0.02f * Direction, 0, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            Direction *= -1;
            Changed = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Changed = false;
    }
}
