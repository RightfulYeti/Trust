using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsScript : MonoBehaviour
{
    SoundManager SMRef;
    private bool Shrunk = false;
    // Start is called before the first frame update
    void Start()
    {
        SMRef = FindObjectOfType<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !Shrunk)
        {
            SMRef.PlaySound("Plop");
            Shrinker();
            Shrunk = true;
            GetComponent<ObjectAI>().Movable = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            SMRef.StopSound("Plop");
        }
    }

    void Shrinker()
    {
        float Timer = 0.0f;
        while (Timer < 0.5f)
        {
            Timer += Time.deltaTime;
            if (gameObject.transform.localScale.y > 0.1f && gameObject.transform.position.y > 0)
            {
                gameObject.transform.localScale += new Vector3(0, -0.000001f, 0);
                gameObject.transform.position += new Vector3(0, -0.1f, 0);
            }
        }
    }
}
