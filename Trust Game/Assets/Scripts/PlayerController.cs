using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 0.0f;
    private float Move = 0.0f;
    private float GroundCheckRadius = 0.2f;
    public float JumpPower = 0.0f;
    bool FacingRight = true;
    bool OnGround = false;

    Collider[] GroundCollisions;
    Rigidbody RB;
    public LayerMask GroundLayer;
    public Transform GroundCheck;


    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move = Input.GetAxis("Horizontal");
        RB.velocity = new Vector3(Move * Speed, RB.velocity.y, 0);

        if (Move > 0 && !FacingRight)
        {
            Flip();
        }
        else if (Move < 0 && FacingRight)
        {
            Flip();
        }

        GroundCollisions = Physics.OverlapSphere(GroundCheck.position, GroundCheckRadius, GroundLayer);
        if (GroundCollisions.Length > 0)
        {
            OnGround = true;
        }
        else
        {
            OnGround = false;
        }

        if (OnGround && Input.GetAxis("Jump") > 0)
        {
            OnGround = false;
            RB.AddForce(new Vector3(0, JumpPower, 0));
        }
    }

    void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 Scale = transform.localScale;
        Scale.z *= -1;
        transform.localScale = Scale;
    }
}
