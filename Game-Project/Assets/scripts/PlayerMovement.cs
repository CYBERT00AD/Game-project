using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject gunRot;
    public float SidewayForce;
    public float ForwardForce;
    public float smoothRotation;
    public GameObject bullet;
    public GameObject bulletSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector3.forward/1;
    }
    void FixedUpdate()
    {
        Plane PlayerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDist = 0.0f;
        if (PlayerPlane.Raycast(ray, out hitDist))
        {
            Vector3 targetPoint = ray.GetPoint(hitDist);
            Debug.Log("targetPoint: " + targetPoint);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            Debug.Log("targetRotation: " + targetRotation);
            targetRotation.x = 0;
            targetRotation.z = 0;
            gunRot.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothRotation * Time.deltaTime);
            //transform.rotation - resultRotation;
            //rb.AddTorque(transform.rotation.eulerAngles - resultRotation.eulerAngles);

            //playerObj.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothRotation * Time.deltaTime);
        }

        if (Input.GetKey("a")) 
            rb.AddForce(-SidewayForce * Time.deltaTime, 0, 0);
        if (Input.GetKey("d"))
            rb.AddForce(SidewayForce * Time.deltaTime, 0, 0);
        if (Input.GetKey("w"))
            rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("s"))
            rb.AddForce(0, 0, -ForwardForce * Time.deltaTime);
        //if (Input.GetMouseButtonDown(0))
            //Shoot();

    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void Shoot() 
    {
        //Debug.Log("Shoot!\n");
        //Instantiate(bullet.transform, bulletSpawnPoint.transform.position, Quaternion.identity);
    }
}
