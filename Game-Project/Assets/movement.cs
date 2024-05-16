using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Vector3 force;
    private Vector3 velocity;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateForce();
        //UpdateVelocity();
        //UpdatePosition();

        rb.GetAccumulatedForce();
    }

    private void UpdateForce()
    {
        if (Input.GetKey(KeyCode.W))
        {
            force.x += speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            force.x -= speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            force.z += speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            force.z -= speed;
        }
        if(rb.GetAccumulatedForce().y < 0)
        {
            force.y += -rb.GetAccumulatedForce().y*2;
        }
        rb.AddForce(force);

    }
    private void UpdateVelocity()
    {
        velocity = force * Time.deltaTime;
    }
    private void UpdatePosition()
    {
        transform.position += velocity * Time.deltaTime;
    }
}
