using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tracksRot : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
        }
        
    }
}
