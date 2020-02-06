using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public float FireRate;
    public GameObject Projectile;

    float NextBullet = 0.0f;
    PlayerController Player;
    Vector3 BulletRotation;

    // Start is called before the first frame update
    void Start()
    {
        Player = transform.root.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Fire1") > 0 && NextBullet < Time.time)
        {
            NextBullet = Time.time + FireRate;
            if(Player.GetDir() == 0)
            {
                BulletRotation = new Vector3(0, -90, 0);
            }
            else
            {
                BulletRotation = new Vector3(0, 90, 0);
            }

            Instantiate(Projectile, transform.position, Quaternion.Euler(BulletRotation));
        }
    }
}
