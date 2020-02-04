using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform Target;
    public float Smoothing = 5.0f;

    private Vector3 Offset;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(Target.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        Offset = transform.position - Target.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 TargetCameraPos = Target.position + Offset;
        transform.position = Vector3.Lerp(transform.position, TargetCameraPos, Smoothing * Time.deltaTime);
    }
}
