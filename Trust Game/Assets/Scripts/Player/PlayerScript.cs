using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float HP;
    private bool HasDiamond = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            HP -= 20;
        }

        if ((other.tag == "GoodPickup" || other.tag == "Friend") && HP < 100)
        {
            HP += 20;
        }

        if (other.tag == "BadPickup")
        {
            HP -= 20;
        }

        if (other.tag == "Diamond")
        {
            HasDiamond = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
    }

    public bool GetHasDiamond()
    {
        if (HasDiamond)
        {
            return true;
        }
        else
            return false;
    }
}
