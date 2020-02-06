using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    SoundManager SMRef;

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
        if (other.tag == "Player")
        {
            SMRef.PlaySound("Plop");
            Destroy(gameObject);
        }
    }
}
