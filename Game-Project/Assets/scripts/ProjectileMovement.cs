using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Target;

    void Start()
    {
        //gameObject[] gameObjects;
        //GameObject[] targets = GameObject.FindGameObjectsWithTag("target");   
        ///GameObject Target = //targets[0];
        transform.LookAt(Target.transform, Vector3.left);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Target.transform, Vector3.left);
    }
}
