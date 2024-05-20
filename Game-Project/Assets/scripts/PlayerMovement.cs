using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float Drag;
    public float Height;
    private Vector3 force;
    private Vector3 velocity;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
    }
    private void FixedUpdate()
    {
        UpdateForce();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //UpdateVelocity();
        //UpdatePosition();

       
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

        
        //Dragging force
        Vector3 vel = rb.velocity;
        force += -1 * vel * Drag;

        //levitation force
        //Vector3(0, -1, 0)
        RaycastHit hit;
        
        if(Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            if (hit.distance < Height )
            {
                force.y = 50 * (Height - hit.distance);

            }

        }

        

        //Movement force
        rb.AddForce(force);



        force *= 0;

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
