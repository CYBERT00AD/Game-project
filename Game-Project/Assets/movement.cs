using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float Drag;
    private Vector3 force;
    private Vector3 velocity;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }
    private void FixedUpdate()
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
            //rb.AddForce(force);
        }
        if (rb.GetAccumulatedForce().y < 0)
        {
            //force.y += -rb.GetAccumulatedForce().y * 2;
        }




        //Vector3 dragForce = Vector3.Scale(vel, 1,0);
        //rb.velocity = new Vector3 (vel.x*0.9f, vel.y * 0.9f, vel.z * 0.9f);
        //rb.drag = 20;
        //Dragging force
        Vector3 vel = rb.velocity; // rb.GetPointVelocity(new Vector3 (0, 0, 0));

        Debug.Log("applied force: "+ ((Vector3) force - rb.GetAccumulatedForce()));
        Debug.Log("Velocity: " + vel);
        //Debug.Log("Drag force: "+ -1 * vel * Drag);

        //Movement force
        rb.AddForce(force);
        //rb.AddForce(force);
        //rb.AddForce(-1*vel * Drag);

        force *= 0;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateForce();
        //UpdateVelocity();
        //UpdatePosition();

       
    }

    private void UpdateForce()
    {
        

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
