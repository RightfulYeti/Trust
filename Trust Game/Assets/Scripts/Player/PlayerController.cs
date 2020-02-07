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
    Rigidbody WhipRB;
    public LayerMask GroundLayer;
    public Transform GroundCheck;
    public GameObject Whip;
    public float XWhip;
    public float YWhip;
    private float Timer;
    private bool Whipping = false;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        WhipRB = GameObject.Find("Whip").transform.GetChild(0).GetComponent<Rigidbody>();
        Whip.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime; 
        if (Timer > 1 && Whipping)
        {
            Whip.SetActive(false);
            Whipping = false;
            Timer = 0;
        }
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

        if (Input.GetKey(KeyCode.E) && !Whipping)
        {
            Whip.SetActive(true);
            WhipRB.AddForce(new Vector3(XWhip, YWhip, 0));
            Whipping = true;
        }
    }

    void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 Scale = transform.localScale;
        Scale.z *= -1;
        transform.localScale = Scale;
    }

    public int GetDir()
    {
        if (FacingRight)
            return 1;
        else
            return 0;
    }
}
