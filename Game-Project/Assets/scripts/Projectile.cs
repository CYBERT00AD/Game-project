using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ProjectileMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Target;
    private Vector3 dir;
    public float speed;
    private bool life = true;
    private Collider ProjectileCollider;
    private Collider TargetCollider;
    

    void Start()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");
        Target = targets[0];
        for (int i = 0; i < targets.Length; i++)
        {
            
            float dist = Vector3.Distance(Target.transform.position, transform.position);
            if ( dist > Vector3.Distance(targets[i].transform.position, transform.position))
            {
                Target = targets[i];
            }
        }
        ProjectileCollider = this.GetComponent<Collider>();  

    }

    // Update is called once per frame
    void Update()
    {
        Move();

        CheckTouch();

        if(life == false)
        {
            Destroy(this);
        }
    }

    private void Move()
    {
        //Find target
        

        //look at target
        transform.LookAt(Target.transform, new Vector3(0, 1, 0));
        transform.Rotate(new Vector3(1, 0, 0), 90);

        //move to target
        dir = Target.transform.position - transform.position;
        dir.Normalize();        
        transform.position += (dir) * speed;

    }

    private void CheckTouch()
    {
        TargetCollider = Target.GetComponent<BoxCollider>();
        //target


        
        if (ProjectileCollider.gameObject.tag == "Target")
            {
            Debug.Log("triggerd");
            //Destroy(this.gameObject);
        }

    

    }
    private void OnTriggerEnter(Collider other)
    {                
        if (other.gameObject.tag == "Target")
        {
            Destroy(this.gameObject);
        }        
    }

}
