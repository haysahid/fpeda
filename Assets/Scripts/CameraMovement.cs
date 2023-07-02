using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private float offsetX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Change offset
        float hInput = Input.GetAxis("Horizontal");

        if (hInput > 0.01f || hInput < -0.01f)
        {
            offset.x = hInput * 1.5f;
        }

        transform.position = new Vector3(
            target.position.x + offset.x,
            transform.position.y,
            transform.position.z);
    }
}
